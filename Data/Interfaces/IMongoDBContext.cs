using Domain;
using MongoDB.Driver;

namespace Data.Interfaces
{
  public interface IMongoDBContext
    {
        IMongoCollection<Team> GetCollection<Team>(string name);
    }
}