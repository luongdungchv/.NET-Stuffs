using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Model
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("price")]
        public string Price { get; set; }
        [BsonElement("base_price")]
        public string BasePrice { get; set; }
        [BsonElement("sum_specs")]
        public string[] SummarySpecs { get; set; }
        [BsonElement("detail_specs")]
        public DetailSpecsModel[] DetailSpecs { get; set; }
        [BsonElement("video_link")]
        public string VideoLink { get; set; }
        [BsonElement("product_details")]
        public string ProducteDetailsLink { get; set; }
        [BsonElement("related_products")]
        public ObjectId[] RelatedProducts { get; set; }
        [BsonElement("images")]
        public string[] Images { get; set; }
    }
    public class DetailSpecsModel
    {
        public string key { get; set; }
        public string[] value { get; set; }
    }
}
