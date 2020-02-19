using System.Threading.Tasks;
using ManagingSoftwareProject.WebApi.Entities;
using ManagingSoftwareProject.WebApi.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManagingSoftwareProject.WebApi.Data
{
    public class ManagingSoftwareProjectWebApiContext : DbContext, IUnitOfWork
    {
        public ManagingSoftwareProjectWebApiContext(DbContextOptions<ManagingSoftwareProjectWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }
        public DbSet<ProdutoPronto> ProdutosProntos { get; set; }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
