# -*- coding: utf-8 -*-  
import glob
import os
import sys

def getTIF(path):
	TIFs=[]
	files=glob.glob(os.path.join(path,'*.tif'))
	return files
	
	

#rootList=['H:\\modis\\EVI\\2015OUTC','H:\\modis\\EVI\\2016OUTC','H:\\modis\\EVI\\2017OUTC']

# root=r'H:\run\ESTARFM\OUT\EVI\maskdat'

root=sys.argv[1]
imgs=glob.glob(os.path.join(root,'*.dat'))
f=open(os.path.join(root,'1NameList.txt'),'w')
f.write(str(len(imgs))+'\n')
for img in imgs:
	f.write(os.path.join(root,img)+'\n')
	print(img)
print('66')