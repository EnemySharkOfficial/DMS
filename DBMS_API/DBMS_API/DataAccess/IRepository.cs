using DBMS_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DBMS_API.DataAccess
{
    public interface IRepository<TContext> : IDisposable where TContext : DbContext
    {
        public Task<int> InsertAsync<TEntity>(TEntity entity)
            where TEntity : BaseEntity;

        public Task<TEntity> GetAsync<TEntity>(long id)
            where TEntity : BaseEntity;

        public Task<List<TEntity>> GetAllAsync<TEntity>()
            where TEntity : BaseEntity;

        public Task<bool> UpdateAsync<TEntity>(TEntity entity)
            where TEntity : BaseEntity;

        public Task<bool> DeleteAsync<TEntity>(long id)
            where TEntity : BaseEntity;

        protected Task Save();
    }
}
