import os
import pandas as pd
import pymongo
import json
import numpy as np
import pandas_ta as ta
from bson import json_util, ObjectId
from bson.json_util import loads
from datetime import datetime, timedelta,date
myclient = pymongo.MongoClient("mongodb://localhost:27017/")

dict=[]
dict1=[]
mydb = myclient["NSEDATA2020FinalDataCopy"]
mycol = mydb["BHAVCOPY1"]
mydb=myclient["NSEDATA_ANALYSIS"]
mycol1=mydb["ALLStockDataCalulation"]



x=list(mycol.find({},{"_id":0,"SYMBOL":1}).limit(1910))

#print(dict)
# HistoricL

for item in range(1,1910):
    a=list(mycol.find(x[item]))# Get data for 1 stock, next round 2nd symbol

    data = pd.DataFrame.from_dict(a)
    #its calulate simple moving Average 5,10,15,20,50
    data['sma05'] = data['CLOSE'].rolling(window=5).mean()
    data['sma10'] = data['CLOSE'].rolling(window=10).mean()
    data['sma15'] = data['CLOSE'].rolling(window=15).mean()
    data['sma20'] = data['CLOSE'].rolling(window=20).mean()
    data['sma50'] = data['CLOSE'].rolling(window=50).mean()
    #its calculate 52weekhigh,low,volume change,average volume,away from 52weekhigh,low
    data['52WeekHigh'] = data['CLOSE'].rolling(265).max()
    data['52WeekLow'] = data['CLOSE'].rolling(265).min()
    data['Volume_changein_20Days']=data['TOTTRDVAL'].rolling(window=20).mean()
    data['Average volume'] = data['TOTTRDVAL']/data['Volume_changein_20Days']
    high_52Week=data['52WeekHigh'].values[265]

    data["Away_From_52WeekHigh"]=(1-(data["CLOSE"])/high_52Week)*100

    low_52Week = data['52WeekLow'].values[265]

    data["Away_From_52WeekLow"] = (data["CLOSE"] / low_52Week-1)*100

    data['Percent_of_Price_Change5_days'] = data['CLOSE'].pct_change(periods=5)

    testdata =data[['SYMBOL','TIMESTAMP','CLOSE','TOTTRDVAL','sma05','sma10','sma15','sma20','sma50','Percent_of_Price_Change5_days','Volume_changein_20Days','Average volume','52WeekHigh','52WeekLow','Away_From_52WeekHigh','Away_From_52WeekLow']]
    testdata.to_csv("AllOperationinStockData.csv")
    print(testdata)




    rec = testdata.to_dict("records")
    mycol1.insert_many(rec)
