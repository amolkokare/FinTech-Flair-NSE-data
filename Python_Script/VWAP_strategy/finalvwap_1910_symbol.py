
# import library
from pymongo import MongoClient
from pandas import DataFrame
import pandas as pd
import numpy as np

# In[142]:


# Connection string
client = MongoClient('mongodb://localhost:27017/')
# accessing the database
mydatabase = client['NSEDATA']
# accessing the daily collection
dailycol = mydatabase['BHAVCOPY']
# accessing the analysis collection
analysiscol = mydatabase['analysis']



# Loop through all rows in collection, print first 2 rows
i = 0
for row in dailycol.find({}):
    if (i < 2):
        print(row)
    i += 1

# In[50]:


# Select distinct symbols
symbols = dailycol.distinct('SYMBOL')
print(symbols)


# In[139]:


# VWAP definition
def fn_vwap(df_in):
    df = df_in.copy()
    df['vwap_pandas'] = (df.TOTTRDQTY * (df.HIGH + df.LOW + df.CLOSE) / 3).cumsum() / df.TOTTRDQTY.cumsum()
    vw = df['vwap_pandas'].iloc[-1]
    return vw


# In[143]:


# Loop through each symbol, get data in each symbol
for sym in symbols:
    data = dailycol.find({'SYMBOL': sym})
    # Convert curor object to list
    list_data = list(data)
    # Convert list to dataframe
    df = DataFrame(list_data)
    i = 0
    c = 0
    lookcback_period = 5
    for index, row in df.iterrows():
        subsetdata = None

        # Slice subset of data for VWAP lookback period
        if (i < lookcback_period):
            subsetdata = df[i - c:i + 1]
            c += 1
        else:
            subsetdata = df[i - lookcback_period + 1:i + 1]

        # Reset index on subsetdata
        subsetdata = subsetdata.reset_index(drop=True)
        # For troubleshooting print below
        # print('subset data')
        # print(subsetdata)

        # Find Highest high index and lowest low index in subsetdata
        high_index = subsetdata['HIGH'].idxmax(axis=0)
        low_index = subsetdata['LOW'].idxmin(axis=0)
        total_rows = len(subsetdata)
        print('lookback Subsetdata:', 'highest high day index-', high_index, 'lowest low day index-', low_index)

        # Slice subsetdata_from_highest_high index day
        if (high_index == total_rows - 1):
            subsetdata_high = subsetdata[high_index:total_rows]
        else:
            subsetdata_high = subsetdata[high_index:total_rows]

        # print('subset data from high')
        # print(subsetdata_high)

        # Slice subsetdata_from_lowest_low index day
        if (low_index == total_rows - 1):
            subsetdata_low = subsetdata[low_index:total_rows]
        else:
            subsetdata_low = subsetdata[low_index:total_rows]

        # print('subset data from low')
        # print(subsetdata_low)

        # Calculate current row VWAPs for three datasets - from lookback, from high, from low
        vw_lookback = fn_vwap(subsetdata)
        vw_from_high = fn_vwap(subsetdata_high)
        vw_from_low = fn_vwap(subsetdata_low)
        print('date:', row['TIMESTAMP'], 'lookback vwap:', vw_lookback,
              'vwap from high:', vw_from_high, 'vwap from low:', vw_from_low)

        # Insert vwap record in analysis table. Upsert if already exits (not coded here).
        # Coordinate inset/upsert with other calculations in analysis table
        newRow = {'symbol': row['SYMBOL'], 'date': row['TIMESTAMP'], 'close': row['CLOSE'], 'volume': row['TOTTRDQTY'],
                  'vwap_lookback': vw_lookback, 'vwap_high': vw_from_high, 'vwap_low': vw_from_low}
        x = analysiscol.insert_one(newRow)

        # increment counter variable
        i += 1

    # In[146]:

# visualize analysis table in dataframe
data = analysiscol.find({})
df = DataFrame(list(data))
df[0:10]


# In[ ]:



