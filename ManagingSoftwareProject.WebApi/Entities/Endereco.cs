using System.ComponentModel.DataAnnotations;
using ManagingSoftwareProject.WebApi.Entities.Interfaces;

namespace ManagingSoftwareProject.WebApi.Entities
{
    public class Endereco : IEntity
    {
        [Key]
        public long Id { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
