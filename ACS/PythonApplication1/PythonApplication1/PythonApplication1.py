f = open(r'data.txt',encoding="utf-8")
list = []
for line in f:
    list.append(line)
outputlist = [];
for i in range(0,100):
    for j in range(1,10):
        outputlist.append(list[j].replace('Test0','Test' + str(i)))
with open("test.txt","w+") as f:
    for i in outputlist:
        f.write(i) 