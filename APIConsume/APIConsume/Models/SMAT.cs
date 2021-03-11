using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using cloudscribe.Pagination.Models;

namespace APIConsume.Models
{
    public class SMAT
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string SYMBOL { get; set; }

        public DateTime TIMESTAMP { get; set; }

        public double CLOSE { get; set; }

        public double HIGH { get; set; }

        public double LOW { get; set; }

        public long Volume { get; set; }

        public double sma05 { get; set; }

        public double sma10 { get; set; }

        public double sma15 { get; set; }

        public double sma20 { get; set; }

        public double sma50 { get; set; }

        public double sma200 { get; set; }

        public double Percent_of_Price_Change5_days   { get; set; }

         public double Volume_changein_20Days { get; set; }

        public double Relative_Volume { get; set; }

         public double WeekHigh52 { get; set; }

        public double WeekLow52 { get; set; }

        public double Away_From_52WeekHigh { get; set; }

        public double Away_From_52WeekLow { get; set; }

        public Nse Nse { get; set; }

        
    }
}
