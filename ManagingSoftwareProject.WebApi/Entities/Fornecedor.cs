using System.ComponentModel.DataAnnotations;
using ManagingSoftwareProject.WebApi.Entities.Interfaces;

namespace ManagingSoftwareProject.WebApi.Entities
{
    public class Fornecedor : IEntity
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public Endereco Endereco { get; set; }
        public string Fone { get; set; }

        private Fornecedor()
        {
        }

        public Fornecedor(string nome, string contato, Endereco endereco, string fone)
        {
            Nome = nome;
            Contato = contato;
            Endereco = endereco;
            Fone = fone;
        }
    }
}
