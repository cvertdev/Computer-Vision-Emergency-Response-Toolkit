#
#
# References:
#    - Spectral Analysis Code: http://www.spectralpython.net/algorithms.html
#         - Code can be found under the section: Target Detectors --> RX Anomaly Detector
#


import sys
import glob
import os
import cv2 as cv
import numpy as np
import scipy as sp
import spectral as spc
from scipy.stats import chi2
#import matplotlib.pyplot as plt

import timer

#----------------------------------------------------Analyze Image----------------------------------------------------

def RXD( image_file, Params):

	#Analysis Variables
	scale_value = 1.0
	chi_threshold = Params["RxChiThreshold"]
	anomaly_threshold = Params["RxThreshold"]

	#Statistics Variables
	t = timer.Timer()

	#Attempt to Analyze
	t.start()

	#Read the input image
	if isinstance(image_file, str):
		src_img = cv.imread( image_file )
	else:
		src_img = image_file

	#Calculate the rx scores for the image
	rx_scores = spc.rx(src_img)

	#Apply a threshold to the rx scores using the chi-square percent point function
	rx_chi = chi2.ppf( chi_threshold, src_img.shape[-1])

	#Create a mask with the threshold values
	rx_mask = (1 * (rx_scores > rx_chi))

	#Apply the mask to the raw rx_scores
	rx_mask = rx_mask * rx_scores

	#Percentage of anomalies above the annomaly_threshold
	stats = ((rx_mask >= anomaly_threshold).sum() / rx_mask.size ) * 100.0

	#Map the reuslting scores into a 0-255 range. This is required to get apply an accurate heatmap. Otherwise, values may overflow and the cooresponding color value will be wrong.
	rx_mask = np.interp(rx_mask, [np.min(rx_mask), np.max(rx_mask)], [0, 255])

	t.stop()

	return rx_mask, t.get_time(), stats
