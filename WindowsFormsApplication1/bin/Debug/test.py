import sys

f=open('1.txt','w')
f.write(sys.argv[1])
f.close()
print(sys.argv[1])