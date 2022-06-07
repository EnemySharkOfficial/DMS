using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_API.Domain.Models.Provider;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DBMS_API.Repositories
{
    public class MongoRepository : IMongoRepository
    {
        private static IMongoDatabase Db;
        private readonly string _connection;
        private readonly MongoClient _client;
        private readonly IMongoCollection<Orders> _collection;

        public MongoRepository()
        {
            _client = new MongoClient("mongodb+srv://ScorpionVSTU:VsTuBoY@scorpioncluster.kb9vl.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Db = _client.GetDatabase("DBMS");
            _collection = Db.GetCollection<Orders>("orders");
        }

        public async Task<string> InsertAsync(Orders record)
        {
            await _collection.InsertOneAsync(record);

            return record.Id;
        }

        public async Task<List<Orders>> GetAllAsync()
        {
            var filter = Builders<Orders>.Filter.Empty;
            var res = await _collection.FindAsync<Orders>(filter);

            return await res.ToListAsync();
        }

        public async Task<Orders> GetAsync(ObjectId id)
        {
            var filter = Builders<Orders>.Filter.Eq("Id", id);
            var res = await _collection.Find(filter).SingleOrDefaultAsync();

            return res;
        }

        public async Task<bool> UpdateAsync(ObjectId id, Orders record)
        {
            var res = await _collection.ReplaceOneAsync(new BsonDocument("_id", id), record, new ReplaceOptions { IsUpsert = true });

            return res.IsAcknowledged && res.ModifiedCount > 0;
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Orders>.Filter.Eq("Id", id);
            var res = await _collection.DeleteOneAsync(filter);
        }
    }
}