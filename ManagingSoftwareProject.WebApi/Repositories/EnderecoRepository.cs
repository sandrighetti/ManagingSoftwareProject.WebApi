using ManagingSoftwareProject.WebApi.Data;
using ManagingSoftwareProject.WebApi.Entities;

namespace ManagingSoftwareProject.WebApi.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>
    {

        public EnderecoRepository(ManagingSoftwareProjectWebApiContext dbContext) : base(dbContext)
        {
        }
    }
}
