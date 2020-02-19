using System.Threading.Tasks;

namespace ManagingSoftwareProject.WebApi.Data.Interfaces
{
    //Interface responsible for keeping track of and saving changes in database    
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
