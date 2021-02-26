using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WatchList.Models
{
    public class Nse
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("WatchList Name")]
        [Required]
        public string Watchlist_name { get; set; }

        [BsonElement("Symbol")]
        [Required]
        public string Symbol { get; set; }


        [BsonElement("Created date")]
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [BsonElement("Modified date")]
        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;


    }
}
