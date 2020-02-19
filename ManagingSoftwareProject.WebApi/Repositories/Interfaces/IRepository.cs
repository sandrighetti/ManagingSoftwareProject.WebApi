using System.Collections.Generic;
using System.Threading.Tasks;
using ManagingSoftwareProject.WebApi.Data.Interfaces;
using ManagingSoftwareProject.WebApi.Entities.Interfaces;

namespace ManagingSoftwareProject.WebApi.Repositories.Interfaces
{
    //Interface responsible for searching, saving and deleting data from repositories in database
    public interface IRepository<T> where T : IEntity
    {
        IUnitOfWork UnitOfWork { get; }
        void Save(T entity);
        void Delete(T entity);
        void Delete(long id);
        Task<T> FindById(long id);
        IEnumerable<T> FindAll();
    }
}
