using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain
{
    public class Team
    {
        [BsonId]
        public string? Id {get; set;}
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public League? Conference { get; set; }
        public bool Powerfive { get; set; }
        public string? Maincolor { get; set; }
        public string? Secondarycolor { get; set; }
        public string? Coachname { get; set; }
    }
}