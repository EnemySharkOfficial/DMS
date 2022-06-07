using DBMS_API.Domain.Models.Provider;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_API.Repositories
{
    public interface IMongoRepository
    {
        public Task<string> InsertAsync(Orders record);

        public Task<List<Orders>> GetAllAsync();

        public Task<Orders> GetAsync(ObjectId id);

        public Task<bool> UpdateAsync(ObjectId id, Orders record);

        public Task DeleteAsync(ObjectId id);

    }
}