using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Models
{
    public class User
    {
         [BsonId]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public Team? Favoriteteam { get; set; }
    }
}