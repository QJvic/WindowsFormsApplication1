import os
import sys

path = sys.argv[1]
deleteStr=sys.argv[2]
count = 1
for file in os.listdir(path):
    print('file:'+file)
    if(deleteStr in file):
        newfile=file.replace(deleteStr,'')
        print('newfile:'+newfile)
        os.rename(os.path.join(path,file),os.path.join(path,newfile))
    count+=1