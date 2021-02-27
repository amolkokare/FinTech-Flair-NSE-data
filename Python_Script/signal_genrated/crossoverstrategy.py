import pymongo
import os
import pandas as pd
import  glob
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["NSEDATA2020FinalDataCopy"] # change # Mongo-DB database name of historical data append
mycol = mydb["BHAVCOPY1"]   # change # Mongo-DB Collection name of historical data append

mydb=myclient["NSEDATA_ANALYSIS"]   # change # Mongo-DB database name of SMA Analysis
mycol1=mydb["SMAAllSTOCKDATA"]  # change # Mongo-DB Collection name of SMA Analysis
mycol2=mydb["SMABACKENDTESTING"]    # change # Mongo-DB New Collection name of backend testing buy and sale signal
dict=[]
x=list(mycol.find({},{"_id":0,"SYMBOL":1}).limit(1910))

for item in range(1, 3):
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
    mycol2.insert_many(rec)





