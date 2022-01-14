using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using MongoDB.Driver;

namespace Data.Context
{
    public class DataContext : IMongoDBContext
    {
        private IMongoDatabase? _db {get; set;}
        private MongoClient? _mongoClient {get; set;}
        private IClientSessionHandle? Session { get; set; }
        public DataContext()
        {
          var settings = MongoClientSettings.FromConnectionString("mongodb+srv://kthomas:Sanai2021@merncluster.whcei.mongodb.net/CFB_DB?retryWrites=true&w=majority");
          _mongoClient = new MongoClient(settings);
          _db = _mongoClient.GetDatabase("CFB_DB");
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
           return _db!.GetCollection<T>(name);
        }
    }
}