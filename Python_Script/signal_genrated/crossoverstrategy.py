import pymongo
import os
import pandas as pd
import  glob
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["NSEDATA2020FinalDataCopy"]
mycol = mydb["BHAVCOPY1"]

mydb=myclient["NSEDATA_ANALYSIS"]
mycol1=mydb["SMAAllSTOCKDATA"]
mycol2=mydb["SMABACKENDTESTING"]
dict=[]
x=list(mycol.find({},{"_id":0,"SYMBOL":1}).limit(1910))

for item in range(0, 3):
    a = list(mycol1.find(x[item]))  # Get data for 1 stock, next round 2nd symbol

    data = pd.DataFrame.from_dict(a)


    data['resultbuy']=(data['sma20']>=data['sma50'])&(data['sma20'].shift(1)<=data['sma50'].shift(1))
    data['resultsell']=(data['sma20']<=data['sma50'])&(data['sma20'].shift(1)>=data['sma50'].shift(1))
    data['resultbuy'] = data['resultbuy'].replace({True: 'BUYSIGNAL', False: 'NA'})
    data['resultsell'] = data['resultsell'].replace({True: 'SELLSIGNAL', False: 'NA'})
    testdata = (data[['SYMBOL','TIMESTAMP','CLOSE','sma20','sma50','resultbuy','resultsell']])
    rec = testdata.to_dict("records")
    testdata.to_csv("datastock.csv")
    print(testdata)
   # mycol2.insert_many(rec)


#testdata.to_csv("cross11511511.csv")

#print(testdata)"""


