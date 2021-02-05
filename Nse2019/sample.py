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
mydb=myclient["ExpontialMoveAverageStockData"]
mycol1=mydb["EMA_TCS"]
for x in mycol.find({'SYMBOL':'TCS'}):
 dict.append(x)
data=pd.DataFrame.from_dict(dict)

ema_ohlc4 = ta.ema(ta.ohlc4(data["Open"], data["High"], data["Low"], data["Close"]), length=10)
ema_ohlc4 = data.ta.ema(close=data.ta.ohlc4(), length=10, suffix="OHLC4"

ewm_pd = pd.DataFrame(ibm).ewm(span=windowSize, min_periods=windowSize).mean().as_matrix()

print(ewm_pd)
testdata=(data[['SYMBOL','SERIES','TIMESTAMP','CLOSE','ema05','ema10','ema15','ema20','ema50']])
rec=testdata.to_dict("records")
mycol1.insert_many(rec)

