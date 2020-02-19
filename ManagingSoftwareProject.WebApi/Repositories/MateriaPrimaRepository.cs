using ManagingSoftwareProject.WebApi.Data;
using ManagingSoftwareProject.WebApi.Entities;

namespace ManagingSoftwareProject.WebApi.Repositories
{
    public class MateriaPrimaRepository : BaseRepository<MateriaPrima>
    {

        public MateriaPrimaRepository(ManagingSoftwareProjectWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
