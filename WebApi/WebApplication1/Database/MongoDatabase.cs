using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Database
{
    public class MongoDatabase : IDatabase
    {
        MongoClient client;
        IMongoDatabase database;
        string collectionName;
        public MongoDatabase(string con, string dbName, string collectionName)
        {
            client = new MongoClient(con);
            database = client.GetDatabase(dbName);
            this.collectionName = collectionName;
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string field, string id) where T: ModelBase
        {
            var collection = database.GetCollection<T>(collectionName);

            var filter = Builders<T>.Filter.Eq(field, id);
            var filter2 = Builders<T>.Filter.Eq(field, id);
            

            var res = collection.Find(filter).FirstOrDefault();
            return res;
        }
        public T Get<T>(MongoFilter<T> filter) where T: ModelBase
        {
            var convertedFilter = Builders<T>.Filter.And(filter.filterList);
            var collection = database.GetCollection<T>(collectionName);
            var res = collection.Find(convertedFilter).FirstOrDefault();
            return res;
        }
        public string Get()
        {
            return null;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
