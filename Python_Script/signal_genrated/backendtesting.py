import pymongo
import os
import pandas as pd
import  glob
myclient = pymongo.MongoClient("mongodb://localhost:27017/")

mydb=myclient["NSEDATA_ANALYSIS"]
mycol1=mydb["SMAAllSTOCKDATA"]
mycol2=mydb["SMABACKENDTESTING"]

a=list(mycol2.find({'resultbuy':'BUYSIGNAL'}))
data = pd.DataFrame.from_dict(a)

c=list(mycol2.find(
    {"$or":[
        {"resultbuy":{"$in":["BUYSIGNAL"]}},
        {"resultsell":{"$in":["SELLSIGNAL"]}}
    ]}
))
datal=pd.DataFrame.from_dict(c)


testdatav= (datal[['SYMBOL', 'TIMESTAMP', 'CLOSE','resultbuy','resultsell']])

print(testdatav)




