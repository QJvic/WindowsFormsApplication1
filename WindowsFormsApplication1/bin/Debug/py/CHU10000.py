import os
import arcpy  
from arcpy.sa import *  
import sys

arcpy.CheckOutExtension("spatial")  
#arcpy.gp.overwriteOutput=1  


def calcRaster(inputPath,outputPath):
	#inputPath='H:\\modis\\EVI\\2015OUTB\\2015009.500m_16_days_EVI.tif'
	#outputPath='H:\\modis\\EVI\\2015OUTB\\testC\\bmm.tif'

	(Raster(inputPath)/10000.0).save(outputPath)
	print '/10000finished'

def getTIF(path):
	TIFs=[]
	files= os.listdir(path)
	for file in files:
		if 'EVI' in file:
			TIFs.append(path+'\\'+file)
	
	return TIFs
	
rootList=['H:\\modis\\EVI\\2012-2014OUT']

rootList=sys.argv[1]
savepath=sys.argv[2]
for root in rootList:
	TIFs=getTIF(root)
	print TIFs
	for TIF in TIFs:
		print TIF
		savePath=''
		#if('2015' in TIF):
			#savePath='H:\\modis\\EVI\\2015OUTC'
		#if('2016' in TIF):
			#savePath='H:\\modis\\EVI\\2016OUTC'
		#if('2017' in TIF):
			#savePath='H:\\modis\\EVI\\2017OUTC'
		# savepath='H:\\modis\\EVI\\2012-201410000.0'	
		(filepath,tempfilename) = os.path.split(TIF)
		(filename,extension) = os.path.splitext(tempfilename)
		outputPath=savePath+'\\'+tempfilename
		calcRaster(TIF,outputPath)
		
	print 'all finished'