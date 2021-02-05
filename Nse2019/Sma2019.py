import os
import pandas as pd
import pymongo
import json
import pandas_ta as ta
from bson import json_util, ObjectId
from bson.json_util import loads
myclient = pymongo.MongoClient("mongodb://localhost:27017/")

dict=[]
mydb = myclient["NSEDATA2019"]
mycol = mydb["BHAVCOPY1"]
mydb=myclient["SimpleMoveAverageStockData"]
mycol1=mydb["SMA_TCS"]
for x in mycol.find({'SYMBOL':'TCS'}):
 dict.append(x)
data=pd.DataFrame.from_dict(dict)
data['sma05']=data['CLOSE'].rolling(window=5).mean()
data['sma10']=data['CLOSE'].rolling(window=10).mean()
data['sma15']=data['CLOSE'].rolling(window=15).mean()
data['sma20']=data['CLOSE'].rolling(window=20).mean()
data['sma50']=data['CLOSE'].rolling(window=50).mean()
testdata=(data[['SYMBOL','SERIES','TIMESTAMP','CLOSE','sma05','sma10','sma15','sma20','sma50']])
rec=testdata.to_dict("records")
mycol1.insert_many(rec)

