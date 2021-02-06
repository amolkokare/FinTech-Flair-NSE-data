import os
import pandas as pd
import pymongo
import json
import numpy as np
import pandas_ta as ta
from bson import json_util, ObjectId
from bson.json_util import loads
myclient = pymongo.MongoClient("mongodb://localhost:27017/")

dict=[]
dict1=[]
mydb = myclient["NSEDATA2020FinalDataCopy"]
mycol = mydb["BHAVCOPY1"]
mydb=myclient["NSEDATA_ANALYSISCheck"]
mycol1=mydb["SMAALLDATA"]
mycol2=mydb["SMA2"]

x=list(mycol.find({},{"_id":0,"SYMBOL":1}).limit(1910))

#print(dict)
# HistoricL
for item in range(1,1910):
    a=list(mycol.find(x[item]))# Get data for 1 stock, next round 2nd symbol
    data = pd.DataFrame.from_dict(a)
    #print(data)
    data['sma05'] = data['CLOSE'].rolling(window=5).mean()
    data['sma10'] = data['CLOSE'].rolling(window=10).mean()
    data['sma15'] = data['CLOSE'].rolling(window=15).mean()
    data['sma20'] = data['CLOSE'].rolling(window=20).mean()
    data['sma50'] = data['CLOSE'].rolling(window=50).mean()
    testdata = (data[['SYMBOL', 'SERIES', 'TIMESTAMP', 'CLOSE', 'sma05', 'sma10', 'sma15', 'sma15', 'sma20', 'sma50']])
    #print(testdata)

    rec = testdata.to_dict("records")
    # print(rec)
    testdata.to_csv("final11216998966.csv")
    mycol1.insert_many(rec)

# a_dict = {'color': 'blue', 'fruit': 'apple', 'pet': 'dog'}"""



"""while True:
      try:
          print(f'Dictionary length: {len(x)}')
          item = x.pop()

          # Do something with item here...
          print(f'{item} removed')
      except KeyError:
          print('The dictionary has no item now...')
          break
# sma  = a.sma # calculate smas
 # insert into smaanalysistable data for 1 symbol, 2 symbol

# Daily
#get today date


#print(dict1)
data=pd.DataFrame.from_dict(dict1)


data['sma10']= ta.sma(data["CLOSE"], length=10,append=True)
#print(data)

data=pd.DataFrame.from_dict(dict1)
data['sma05']=data['CLOSE'].rolling(window=5).mean()
data['sma10']=data['CLOSE'].rolling(window=10).mean()
data['sma15']=data['CLOSE'].rolling(window=15).mean()
data['sma20']=data['CLOSE'].rolling(window=20).mean()
data['sma50']=data['CLOSE'].rolling(window=50).mean()
testdata=(data[['SYMBOL','SERIES','TIMESTAMP','CLOSE','sma05','sma10','sma15','sma15','sma20','sma50']])

rec=testdata.to_dict("records")
 #print(rec)
testdata.to_csv("final1121699.csv")
mycol1.insert_many(rec)"""

