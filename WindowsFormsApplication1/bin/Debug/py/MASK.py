# -*- coding: utf-8 -*-   
# Name: ExtractByMask_Ex_02.py
# Description: Extracts the cells of a raster that correspond with the areas
#    defined by a mask.
# Requirements: Spatial Analyst Extension

# Import system modules


import arcpy
from arcpy import env
from arcpy.sa import *
import os
import glob
import sys



# rootList=['H:\\run\\ESTARFM\\OUT\\EVI']
# savePath='H:\\run\\ESTARFM\\OUT\\EVI\\mask'	
# shpPath='t\\2017.shp'

mode=sys.argv[4]

rootList=[sys.argv[1]]
savePath=sys.argv[3]
shpPath=sys.argv[2]

def getTIF(path):
	TIFs=[]
	files=glob.glob(os.path.join(path,'*.tif'))
	return files
def Mask(raster,feature):
	inRaster = "elevation"
	inMaskData = "mask.shp"
	
	# Set environment settings
	env.workspace = "H:\\modis\\EVI"
	
	# Check out the ArcGIS Spatial Analyst extension license
	arcpy.CheckOutExtension("Spatial")
	
	arcpy.gp.overwriteOutput=1
	# Execute ExtractByMask
	#outExtractByMask = ExtractByMask(raster, feature)

	#savePath=''

	#savePath='H:\\modis\\EVI\\2015-2017CJ'	
	(filepath,tempfilename) = os.path.split(raster)
	(filename,extension) = os.path.splitext(tempfilename)
	# Save the output 
	#print filepath+'  '+tempfilename
	#outExtractByMask.save(savePath+'\\'+tempfilename)
	print savePath+'\\'+tempfilename
	print feature,savePath+'\\'+filename
	arcpy.gp.ExtractByMask_sa(raster, feature,savePath+'\\'+tempfilename)  
	print 'one finished!!!!!!!!!'

if mode=='文件夹':
	for root in rootList:
		TIFs=getTIF(root)
		print TIFs
		for TIF in TIFs:
			print TIF
			Mask(TIF,shpPath)
		print 'all'

if mode=='单个':
	Mask(rootList[0],shpPath)
	print 'all'