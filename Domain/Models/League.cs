using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Models
{
    public class League
    {
         [BsonId]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Team>? Members { get; set; }
        public bool Powerfive { get; set; }
    }
}