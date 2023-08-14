using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController: ControllerBase
    {
        string connectionString = "mongodb://localhost:27017";
        string dbName = "User";
        string collectionName = "UserInfo";

        [HttpGet]
        [Route("{id}")]
        public ActionResult TestAction(string id)
        {
            //try
            //{
            //    MongoDatabase dbConnection = new MongoDatabase(connectionString, dbName, collectionName);
            //    var result = dbConnection.Get<UserProfile>("username", id);
            //    return Ok(JsonConvert.SerializeObject(result));
            //}
            //catch(Exception e)
            //{
            //    Console.Write(e);
            //    return NoContent();
            //}
            var json = id;
            return Ok(json);
        }
        [HttpPost, Route("post")]
        public ActionResult PostResult([FromBody] PostData data)
        {
            MongoDatabase dbConnection = new MongoDatabase(connectionString, dbName, collectionName);
            //var result = dbConnection.Get<UserProfile>("UserAccount", data.Username);
            var filter = new MongoFilter<UserProfile>();
            filter.Eq(u => u.UserAccount, data.Username)
                .Eq(u => u.LoginPassword, data.Password);
            var result = dbConnection.Get(filter);
            if (result == null)
            {
                return Ok("failed");
            }
            result.UserName = null;
            result.LoginPassword = null;
            var resData = new UserProfileResponseData()
            {
                uid = result.Id,
                token = result.AccessToken
            };
            return Ok(JsonConvert.SerializeObject(resData));
        }
        [HttpGet, Route("download/{id}")]
        public IActionResult DownloadResult(string id)
        {
            foreach (var i in Request.Headers)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
            if (id == "t") return Ok("asdfagsdfh");
            var file = System.IO.File.ReadAllBytes($"D:/{id}.mp4");
            return new FileContentResult(file, "video/mp4");
            //return PhysicalFile($"D:/{id}.mp4", "video/mp4", "test.txt");
        }
        
    }
    
}
