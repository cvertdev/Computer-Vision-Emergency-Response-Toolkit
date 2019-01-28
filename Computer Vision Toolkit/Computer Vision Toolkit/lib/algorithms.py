# Import the required libraries
import sys
import os
import cv2 as cv
import numpy as np
import json

from operator import itemgetter

#Timer class
import timer  
from status import status, log  


#========================================================================================================
#---------------------------------------------Setup Algorithms-------------------------------------------
#========================================================================================================

# Import algorithm libraries
from Algorithms.RXDetector import RXD
from Algorithms.DXDetector import DebrisDetect
from Algorithms.AODNet import Dehaze



#Default parameters for each algorithm
Params = {
    "RxThreshold":90.0,
    "RxChiThreshold":0.999,
    "LineGaussianIter":0, 
    "LineDilationIter":1, 
    "LineBilatBlurColor":75,
    "LineBilatBlurSpace":75, 
    "LineCannyEdgeLowerBound":100,
    "LineCannyEdgeThreshold":140, 
    "CornerGaussianIter":0,
    "CornerErosionIter":1,
    "CornerBilateralColor":200,
    "CornerBilateralSpace":500, 
    "CornerMaxDistance":75, 
    "CornerNumPoints":3
    
    }



#List of aglorithm functions
Alg_List = { 
	'RXD':RXD,
    'DebrisDetect':DebrisDetect,
	'Dehaze':Dehaze
    
    }

Alg_Order = {
	'RXD':2,
    'DebrisDetect':3,
	'Dehaze':1
   
	}

Alg_Pipe = {
    'RXD':0,
    'DebrisDetect':0,
	'Dehaze':0
   
    }




#========================================================================================================
#------------------------------------------Read Parameters File------------------------------------------
#========================================================================================================

#Get parameters.ini file
paramFile = open(os.path.join( os.path.dirname(sys.argv[0]), "parameters.ini"), "r")

#Add code to read in the parameters from the file Here to overwrite the defaults
for line in paramFile:
    if line[0] == '#':
        pass
    else:
        #split the line into a list
        splitLine=line.strip().split("=")

        #see if parameter is in our dictionary
        #splitline[1] is 1 for default, 0 for User value
        if splitLine[0] in Params and int(splitLine[1]) is 0:
            Params[splitLine[0]] = float(splitLine[3])


#========================================================================================================
#------------------------------------------Read Algortihms File------------------------------------------
#========================================================================================================

#Get algorithms.ini file
algFile = open(os.path.join( os.path.dirname(sys.argv[0]), "algorithms.ini"), "r")
#Add code to read in the parameters from the file Here to overwrite the defaults
for line in algFile:
	if line[0] == '#':
		pass
	else:
		#split the line into a list
		splitLine=line.strip().split("=")

        #see if the algorithm is in our dictionary
        #splitline[2] determines if th algorithm will be used during analysis. 1 for use, 0 for not use
		if splitLine[0] in Alg_Order:
			if int(splitLine[2]) is 1:
				Alg_Order[splitLine[0]] = int(splitLine[3])
				Alg_Pipe[splitLine[0]] = int(splitLine[1])
			else:
				Alg_Order[splitLine[0]] = -1		#Set the order to -1. This means that the algorithm will not be used in the analysis.


#========================================================================================================
#-------------------------------------------Run the Algorithms-------------------------------------------
#========================================================================================================

def algorithms(image_path, apply_heatmap=True, range_min=0, range_max=255, scale_value = 1.0):
    
	#Read image from an object or file path
	if isinstance(image_path, str):
		image = cv.imread( image_path, cv.IMREAD_COLOR )
	else:
		image = image_path

	#Scale the image
	if scale_value != 1.0:
		height, width = image.shape[:2]
		image = cv.resize( image, (int( width * scale_value ), int( height * scale_value)), interpolation=cv.INTER_LINEAR)

	#Setup the scores matrix
	scores = np.zeros(image.shape[:2])
	time = float(0)
	stats = float(0)

	#Create the unused image list
	unused_images = []
    
	#--------------------------------------------------------------------------------------------------------
	#--------------------------------------------------------------------------------------------------------

	#Sort the algorithms to use by the order saved by the user. This is stored in the 'algorithms.ini' file
	alg_sorted = sorted(Alg_Order.items(), key=lambda kv: kv[1], reverse=False)
	
    #Run the algorithms
    #for alg in Alg_List.items():
	for alg in alg_sorted:
		if alg[0] in Alg_List and alg[1] != -1:		#Check if this algorithm will be run

			if alg[0] is 'Dehaze':		#The Dehaze algorithm always requires it to be piped into another algorithm
				Alg_Pipe[alg[0]] = 1

			if alg[0] in Alg_Pipe and Alg_Pipe[alg[0]] == 1:	#Check if this algorithm's results need to be piped into other algorithms
				rtn = Alg_List[alg[0]](image, Params)
				
				#Convert a 2D matrix of scores into a grayscale 3 channel image
				if len(rtn[0].shape) < 3:
					image = cv.applyColorMap( rtn[0].astype(np.uint8), cv.COLORMAP_BONE )
				else:
					image = rtn[0]

			else:
				#Get the function from Alg_List and run it
				rtn = Alg_List[alg[0]](image, Params)

			#Add the current algorithm's results to the overall results
			if len(rtn[0].shape) < 3:
				scores += rtn[0]
			else:
				unused_images.append(rtn[0])
			

			#Add the current algorithm's completion time and statistics
			time += rtn[1]
			stats += rtn[2]

	#--------------------------------------------------------------------------------------------------------
	#--------------------------------------------------------------------------------------------------------

	#Map final scores to the range [0,255]
	scores = np.interp(scores, [np.min(scores),np.max(scores)], [range_min, range_max])

	#Return the results
	return scores, time, stats, unused_images



#========================================================================================================
#----------------------------------------------Run an Analysis-------------------------------------------
#========================================================================================================

#Analyze the given image (img)
def run_analysis(args):
	img = args[0]           #Image to be analyzed
	batch_path = args[1]    #Used for save location

	batch_log = open(os.path.join(batch_path, 'batch_log.txt'), 'a+')
	detected_log = open(os.path.join(batch_path, 'detected_log.txt'), 'a+')
	other_log = open(os.path.join(batch_path, 'other_log.txt'), 'a+')

	#Accepted extensions
	ext = os.path.splitext(img)[-1]

	#Image name to save the heatmap under
	img_name = ".".join(os.path.split(img)[1].split(".")[:-1])

	#Handles video input
	if ext.lower() == ".mp4":
		#Create and start the timer
		t = timer.Timer()
		t.start()

		#Analyze the video
		rtn_name = analyzeVideo( (img, batch_path, 30) )

		#Stop the timer
		t.stop()

		#Log the results
		rtn_str =  rtn_name, t.get_time(), 0.0
		status('-v-', rtn_str )
		log(detected_log, '-v-', rtn_str )

	else:
        
		#Call the algorithms
		final_scores, final_time, final_stats, unused_images = algorithms(img)

		#--------------------------------------------------------------------------------------------------------
		#--------------------------------------------------------------------------------------------------------

		#Apply colormap to the combined heatmap if it is not already a color image
		if len(final_scores.shape) < 3:
			final_heatmap = cv.applyColorMap( final_scores.astype(np.uint8), cv.COLORMAP_JET )
		

		#--------------------------------------------------------------------------------------------------------
		#--------------------------------------------------------------------------------------------------------

		#Save heatmap in the correct folder
		if np.max(final_scores) >= 50:
			results_str = [ img_name, final_time, final_stats ]
			status('-d-', results_str)
			log(batch_log, '-d-', results_str)
			log(detected_log, '-d-', results_str)
			#cv.imwrite(os.path.join( detected_folder, img_name + ".jpg"), final_heatmap)
			cv.imwrite(os.path.join( batch_path, "Detected", img_name + ".jpg"), final_heatmap)        

		else:
			results_str = [ img_name, final_time, final_stats ]
			status( '-o-', results_str)
			log(batch_log, '-o-', results_str)
			log(other_log, '-o-', results_str)
			#cv.imwrite(os.path.join( other_folder, img_name + ".jpg"), final_heatmap)
			cv.imwrite(os.path.join(  batch_path, "Other", img_name + ".jpg"), final_heatmap)      
			
		#Save any resulting images from the algorithms that couldn't be used to produce the heatmap
		ct = 1
		for u_img in unused_images:
			results_str = "An unused image was detected. Image saved to 'Other' folder."
			status( '-i-', results_str)
			log(batch_log, '-i-', results_str)
			log(other_log, '-i-', results_str)
			cv.imwrite(os.path.join(  batch_path, "Other", img_name + "_UNUSED_" + str(ct) + ".jpg"), u_img)    
			ct += 1

	batch_log.close()
	detected_log.close()
	other_log.close()
	return



#========================================================================================================
#--------------------------------------------Run a Video Analysis----------------------------------------
#========================================================================================================

def analyzeVideo(args):
	video_path = args[0]
	batch_path = args[1]
	fps = args[2]

	vid_name = ".".join(os.path.split(video_path)[1].split(".")[:-1])
	vid_capture = cv.VideoCapture(video_path)
	success, frame = vid_capture.read()
	size = (frame.shape[1],frame.shape[0])
    
	count = 0
	success = True

	save_path = os.path.join(batch_path, "Videos")
	if not os.path.exists(save_path):
		os.makedirs(save_path)

	fourcc = cv.VideoWriter_fourcc('D', 'I', 'V', 'X')
	out = cv.VideoWriter(os.path.join(save_path, vid_name + '_heatmap.mp4'), fourcc, int(fps), size)

	#TODO: Add ability to toggle video output during analysis
	show_progress = True
	key_pressed = 0

	#Extract frames
	while success:
		frame_str = "frame{0}.jpg".format(count)

		#cv.imwrite(os.path.join(save_path, frame_str), frame)     # save frame as JPEG file
		#heatmap_frame = cv.applyColorMap( algs.algorithms(os.path.join(save_path, frame_str))[0].astype(np.uint8), cv.COLORMAP_JET )

		heatmap_frame = cv.applyColorMap( algorithms(frame)[0].astype(np.uint8), cv.COLORMAP_JET )
		out.write(heatmap_frame)

		success, frame = vid_capture.read()
		count += 1

		#Display progress
		if show_progress:
			cv.namedWindow('Generating Video Heatmap - Press ESCAPE to close', cv.WINDOW_KEEPRATIO)
			cv.resizeWindow('Generating Video Heatmap - Press ESCAPE to close', (500, 375))
			cv.imshow('Generating Video Heatmap - Press ESCAPE to close', heatmap_frame)
			key_pressed = cv.waitKey(1)
        
		if key_pressed == 27:
			show_progress = False
			cv.destroyAllWindows()
        
	cv.destroyAllWindows()
	out.release()
	return os.path.join( vid_name + '_heatmap.mp4')
