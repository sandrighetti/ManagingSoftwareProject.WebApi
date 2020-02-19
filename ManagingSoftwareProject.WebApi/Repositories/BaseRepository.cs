using System.Threading.Tasks;
using System.Collections.Generic;
using ManagingSoftwareProject.WebApi.Data;
using ManagingSoftwareProject.WebApi.Data.Interfaces;
using ManagingSoftwareProject.WebApi.Entities.Interfaces;
using ManagingSoftwareProject.WebApi.Repositories.Interfaces;

namespace ManagingSoftwareProject.WebApi.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ManagingSoftwareProjectWebApiContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public BaseRepository(ManagingSoftwareProjectWebApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Save(T entity)
        {
            if (entity == null)
            {
                _dbContext.Add(entity);
            }
            _dbContext.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public async void Delete(long id)
        {
            var entity = await FindById(id);
            if (entity == null)
                return;

            _dbContext.Remove(entity);
        }

        public virtual async Task<T> FindById(long id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public virtual IEnumerable<T> FindAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
