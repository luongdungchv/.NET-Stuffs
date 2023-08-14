using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;


namespace WebApplication1.Models
{
    public class UserProfile: ModelBase
    {
        [BsonElement("username")]
        public string UserName { get; set; }

        [BsonElement("user_account")]
        public string UserAccount { get; set; }

        [BsonElement("login_password")]
        public string LoginPassword { get; set; }

        [BsonElement("access-token")]
        public string AccessToken { get; set; }

        [BsonElement("dob")]
        public string Dob { get; set; }
        public int test;
    }
}
