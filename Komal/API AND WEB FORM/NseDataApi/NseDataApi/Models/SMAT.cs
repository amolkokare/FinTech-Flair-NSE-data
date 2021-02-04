using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NseDataApi.Models
{
    public class SMAT
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string SYMBOL { get; set; }

        public string SERIES { get; set; }

        public string TIMESTAMP { get; set; }

        public double CLOSE { get; set; }

        public double sma05 { get; set; }

        public double sma10 { get; set; }

        public double sma15 { get; set; }

        public double sma20 { get; set; }

        public double sma50 { get; set; }




    }
}
