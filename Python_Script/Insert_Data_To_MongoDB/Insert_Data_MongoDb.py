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

os.chdir(r"D:\NSEDATA\2021")
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["NSEDATA2020FinalDataCopy"]
mycol = mydb["BHAVCOPY1"]
filelist=glob.glob("*.csv")
dflist=[]

for filename in filelist:
    df=pd.DataFrame(pd.read_csv(filename))
    dflist.append(df)
concatdf=pd.concat(dflist)
rec = concatdf.to_dict("records")

mycol.insert_many(rec)


import shutil, os

for f in filelist :

    newpath=r"D:\\NSEPROCESSDATA\\2021"
    shutil.move(f, newpath)

    if not os.path.exists(newpath):
        os.makedirs(newpath)

