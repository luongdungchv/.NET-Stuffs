using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace WebApplication1.Models
{
    [Serializable]
    public class Message: ModelBase
    {
        
        [BsonElement("message")]
        public string MessageDetail { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("timeStamp")]
        public string TimeStamp { get; set; }
        [BsonElement("received")]
        public bool Received { get; set; }
        [BsonElement("__v")]
        public int V { get; set; }
    }
}
