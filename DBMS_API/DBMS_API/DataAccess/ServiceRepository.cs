using AutoMapper;
using DBMS_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DBMS_API.DataAccess
{
    public class ServiceRepository : IRepository<ServiceDepartmentContext>
    {
        private readonly ServiceDepartmentContext _context;
        private bool Disposed = false;
        private readonly IMapper _mapper;

        public ServiceRepository(ServiceDepartmentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync<TEntity>(long id) where TEntity : BaseEntity
        {
            var entity = await _context.Set<TEntity>().FirstAsync(a => a.Id == id);
            if (entity == null) { return false; }
            _context.Set<TEntity>().Remove(entity);
            await Save();
            return true;
        }

        public async Task<List<TEntity>> GetAllAsync<TEntity>() where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetAsync<TEntity>(long id) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().FirstAsync(a => a.Id == id);
        }

        public async Task<int> InsertAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await Save();
            return entity.Id;
        }

        public async Task<bool> UpdateAsync<TEntity>(TEntity newEntity) where TEntity : BaseEntity
        {
            var entity = await _context.Set<TEntity>().Where(i => i.Id == newEntity.Id).FirstAsync();
            _mapper.Map(newEntity, entity);

            await Save();

            return true;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
