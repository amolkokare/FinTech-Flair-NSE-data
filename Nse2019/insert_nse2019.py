import pymongo
import os
import pandas as pd
import  glob
import zipfile
import json
import shutil
import pathlib
import numpy
from  pathlib import Path

os.chdir(r"E:\NSEDATA\2019")
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["NSEDATA2019"]
mycol = mydb["BHAVCOPY1"]
filelist=glob.glob("*.csv")
dflist=[]
colnames=["SYMBOL","SERIES","OPEN","HIGH","LOW","CLOSE","LAST","PREVIOUSCLOSE","TOTTRDQTY","TOTTRDVAL","TIMESTAMP","TOTALTRADES","ISIN",""]

for filename in filelist:

    df=pd.DataFrame(pd.read_csv(filename,header=1,index_col=None))
    colnames = ["SYMBOL","SERIES","OPEN","HIGH","LOW","CLOSE","LAST","PREVIOUSCLOSE","TOTTRDQTY","TOTTRDVAL","TIMESTAMP", "TOTALTRADES", "ISIN",""]
    df.columns = colnames
    dflist.append(df)
    concatdf=pd.concat(dflist,axis=0,ignore_index=True)

    concatdf.to_csv(r"E:\NSEALLDATA\n19.csv")
data=pd.read_csv(r"E:\NSEALLDATA\n19.csv")

data_json = json.loads(data.to_json(orient='records'))
mycol.insert_many(data_json)
import shutil, os

for f in filelist :

    newpath=r"E:\\NSEPROCESSDATA\\2019\\"
    shutil.move(f, newpath)

    if not os.path.exists(newpath):
        os.makedirs(newpath)

