using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace NseApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Symbol")]
        public string Symbol { get; set; }
        
        public string Timestamp { get; set; }
        public string Name { get; set; }

        public string Sma05 { get; set; }

        public string Sma10 { get; set; }

        public string Sma20 { get; set; }

        public string Sma50 { get; set; }
    }
}
