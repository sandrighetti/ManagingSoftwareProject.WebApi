using ManagingSoftwareProject.WebApi.Data;
using ManagingSoftwareProject.WebApi.Entities;

namespace ManagingSoftwareProject.WebApi.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>
    {

        public FornecedorRepository(ManagingSoftwareProjectWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
