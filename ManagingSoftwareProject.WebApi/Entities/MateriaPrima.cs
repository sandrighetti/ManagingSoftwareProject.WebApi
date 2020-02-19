using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ManagingSoftwareProject.WebApi.Enums;
using ManagingSoftwareProject.WebApi.Entities.Interfaces;

namespace ManagingSoftwareProject.WebApi.Entities
{
    public class MateriaPrima : IEntity, IProduto
    {
        [Key]
        public long Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public IEnumerable<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public UnidadeMedida UnidadeMedida { get; set; }
        public Agrupamento Agrupamento { get; set; }

        private MateriaPrima()
        {
        }

        public MateriaPrima(int codigo, string descricao, double valor, UnidadeMedida unidadeMedida, Agrupamento agrupamento)
        {
            Codigo = codigo;
            Descricao = descricao;
            Valor = valor;
            UnidadeMedida = unidadeMedida;
            Agrupamento = agrupamento;
        }
    }
}
