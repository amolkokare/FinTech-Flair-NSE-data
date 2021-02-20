using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIConsume.Models
{
    public class SMAT
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string SYMBOL { get; set; }

        public string SERIES { get; set; }
        public string TIMESTAMP { get; set; }

        //public double OPEN { get; set; }

        public double CLOSE { get; set; }

        //public double HIGH { get; set; }

       // public double LOW { get; set; }

        //public double TOTTRDQTY { get; set; }

        public double sma05 { get; set; }

        public double sma10 { get; set; }

        public double sma15 { get; set; }

        public double sma20 { get; set; }

        public double sma50 { get; set; }

        //public double sma200 { get; set; }

        //public double Avg_Price_5days { get; set; }

       // public double Avg_Vol_20day { get; set; }

        //public double Relative_Volume { get; set; }

       // public double WeekHigh52 { get; set; }

        //public double WeekLow52 { get; set; }

        //public double Away_52WeekHigh { get; set; }

        //public double Away_52WeekLow { get; set; }

    }
}
