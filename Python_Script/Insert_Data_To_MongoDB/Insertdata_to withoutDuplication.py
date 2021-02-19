import pymongo
import os
import datetime,time

import pandas as pd
import glob
import zipfile
import json,codecs
import shutil

dflist=[]
m=[]
os.chdir(r"D:\NSEDATA\2021")
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["NSEDATA2020FinalDataCopy"]
mycol = mydb["BHAVCOPY1"]
#mydb.mycol.create_index([{"TIMESTAMP"}], unique=True )
filelist=glob.glob("*.csv")
for filename in filelist:
    df = pd.DataFrame(pd.read_csv(filename))
    dflist.append(df)
    concatdf = pd.concat(dflist)
   # print(concatdf)
    rec = concatdf.to_dict("records")

"""dict=[]
for x in mycol.find({'TIMESTAMP':1}):
 dict.append(x)
 print(x)"""
#print(concatdf)

#AB=list(mycol.find({}, {"_id":0,"TIMESTAMP":1, "SYMBOL":1}))
newpath = r"D:\\NSEPROCESSDATA\\2021"
Q=list(mycol.find({},{ "SYMBOL":1,"TIMESTAMP": 1}))
data = pd.DataFrame.from_dict(Q)
A=(concatdf["TIMESTAMP"])

#print(data)
#print(A)
if (set(concatdf["TIMESTAMP"]).intersection(set(data['TIMESTAMP']))):
    print("File is alredy present")
    #newfilename = os.path.join(r"D:\NSEDATA\2021",date.strftime('%Y-%m-%d.csv'))
    newpath1 =r"D:\\Error_file"
    print("File is Succesfully Moved to Error Folder")

    shutil.move(filename, newpath1)
    #timestamp_name = int(.time())#
    #os.rename('path/to/file/name.csv', 'path/to/file/' + timestamp_name + '.csv')
    #os.remove(filename)
    #print(newfilename)

else:
 print("not present")
 print("inserted Successfully")
 mycol.insert_many(rec)
 shutil.move(filename, newpath)
 print("Moved Successfully",filename)

"""newpath = r"D:\\NSEPROCESSDATA\\2021"

 #for f in filelist :

if os.fspath(filename):


print("file is successfully Moved",filename)
if  os.path.exists(newpath):
    print("file alrady present")

else:
 
print(filename)

#if not os.path.exists(newpath):
    # os.makedirs(newpath)"""






