using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIConsume.Models
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

        [BsonElement("Search_Symbol")]
        [Required]
        public string Search_Symbol { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

          public SMAT SMAT { get; set; }


    }
}
