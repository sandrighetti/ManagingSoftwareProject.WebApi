using ManagingSoftwareProject.WebApi.Data;
using ManagingSoftwareProject.WebApi.Entities;

namespace ManagingSoftwareProject.WebApi.Repositories
{
    public class ProdutoProntoRepository : BaseRepository<ProdutoPronto>
    {

        public ProdutoProntoRepository(ManagingSoftwareProjectWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
