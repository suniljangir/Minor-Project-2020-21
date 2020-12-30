data = open('/ws33/mnistcnn.py','r')
content=data.read()
content=content.splitlines()
content[14]='epochs+=1'
data = open('/ws33/mnistcnn.py','w')
data.write('\n'.join(content))
data.close()