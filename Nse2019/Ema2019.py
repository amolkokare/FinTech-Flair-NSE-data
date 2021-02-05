import array
import os
import pandas as pd
import pymongo
import json
import pandas_ta as ta
from bson import json_util, ObjectId
from bson.json_util import loads

from Sma2019 import data

myclient = pymongo.MongoClient("mongodb://localhost:27017/")

df=pd.Series(data)
pd.ewma(df, span=5)
pd.ewma(df, span=5, min_periods=5)

dict = []
mydb = myclient["NSEDATA2019"]
mycol = mydb["BHAVCOPY1"]
mydb = myclient["ExpontialMoveAverageStockData"]
mycol1 = mydb["EMA_TCS"]
for x in mycol.find({'SYMBOL': 'TCS'}):
    dict.append(x)
df = pd.DataFrame.from_dict(dict)



df['ema5'] = pd.Series.ewm(df['close'],span=5).mean( )
'''data['ema05']=pd.Series.ewm(data['CLOSE'].rolling(window=5)).mean()'''



testdata=(df[['SYMBOL','SERIES','TIMESTAMP','CLOSE','ema5']])
rec=testdata.to_dict("records")
mycol1.insert_many(rec)
