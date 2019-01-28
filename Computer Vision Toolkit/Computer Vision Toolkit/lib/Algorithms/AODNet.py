import numpy as np
import cv2
from scipy.signal import convolve2d

import timer

# Padding size defined for every convolutional layer of AOD-Net
conv_padding = {'conv1': 0,
				'conv2': 1,
				'conv3': 2,
				'conv4': 3,
				'conv5': 1}

def conv(name, input, weights, bias):
	"""
	Computes output of a convolutional layer for the given input, weights and bias for the respective layer of AOD-Net.
	"""

	global conv_padding

	filter_feat_maps = []
	for i in range(weights.shape[0]):
		feat_maps = []
		for j in range(weights.shape[1]):
			feat_maps.append(convolve2d(np.pad(input[0, j, :, :], conv_padding[name], 'constant'), weights[i, j, :, :], mode='valid'))
		
		filter_feat_maps.append(np.sum(feat_maps, axis=0) + bias[i])

	filter_feat_maps = np.dstack(filter_feat_maps)
	filter_feat_maps = np.expand_dims(filter_feat_maps, axis=0).transpose(0,3,1,2)

	return filter_feat_maps

def relu(input):
	"""
	Computes ReLU activation function
	"""

	return np.maximum(input, 0)

def aod_net(x, np_weights):
	"""
	Gives dehazed image output for input 'x' of size (1 x num_channels x height x width) 
	using given model weights for AOD-Net (All-in-One Dehazing Network, Boyi Li et. al., 2017)
	"""

	b = 1

	x1 = relu(conv('conv1', x, np_weights['conv1']['weights'], np_weights['conv1']['bias']))
	x2 = relu(conv('conv2', x1, np_weights['conv2']['weights'], np_weights['conv2']['bias']))
	cat1 = np.concatenate((x1, x2), axis=1)
	x3 = relu(conv('conv3', cat1, np_weights['conv3']['weights'], np_weights['conv3']['bias']))
	cat2 = np.concatenate((x2, x3), axis=1)
	x4 = relu(conv('conv4', cat2, np_weights['conv4']['weights'], np_weights['conv4']['bias']))
	cat3 = np.concatenate((x1, x2, x3, x4), axis=1)
	k = relu(conv('conv5', cat3, np_weights['conv5']['weights'], np_weights['conv5']['bias']))

	if k.shape != x.shape:
		raise Exception("k, hazy image are of different sizes!")

	output = k * x - k + b

	return relu(output)


def Dehaze(img_path, Params = None, model_path = 'lib/Algorithms/pretrained_aod_net_numpy.npy'):
	"""
	Primary function for interfacing with the dehazing network. Provide an image path and will return a numpy image.

	Loading image: For the input image, cv2.imread always loads a 3-channel image which is the requirement of the AOD-Net. 
	So load any grayscale image as a 3-channel image.
	"""

	#Statistics Variables
	t = timer.Timer()

	#Attempt to Analyze
	t.start()

	#Read the input image
	if isinstance(img_path, str):
		img = cv2.imread( img_path, cv2.IMREAD_COLOR )
	else:
		img = img_path

	#img = cv2.imread(img_path)		#Replaced with the above if-else

	img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)		#OpenCV's BGR to RGB
	#img = img[...,::-1]		# BGR to RGB

	img = img / 255.0		# Normalizing in 0-1 range
	x = np.expand_dims(img, axis=0).transpose(0,3,1,2)

	# Loading model weights
	np_weights = np.load(model_path).item()

	output = aod_net(x, np_weights)
	output = np.squeeze(output)
	output = (output*255).astype(np.uint8) # RGB numpy image array
	output = output.transpose(1,2,0)
	
	#Convert back to BGR
	output = cv2.cvtColor(output, cv2.COLOR_RGB2BGR)	#OpenCV's RGB to BGR

	#Stop the timer
	t.stop()

	return output, t.get_time(), 0



def dehaze_and_display(img_path, model_path = 'lib/Algorithms/pretrained_aod_net_numpy.npy'):
	"""
	Dehazes and then displays the dehazed image. 
	"""
	
	dehazed_image = Dehaze(img_path, model_path= model_path)
	from PIL import Image
	PIL_img = Image.fromarray(dehazed_image)
	PIL_img.show()
	

# --------------------------- Debugging and Testing ------------------------------
# if __name__ == '__main__':
# 	dehaze_and_display(img_path = './Examples/sample5.jpg');