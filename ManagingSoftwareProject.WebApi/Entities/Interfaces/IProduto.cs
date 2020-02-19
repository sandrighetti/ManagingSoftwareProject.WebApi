using ManagingSoftwareProject.WebApi.Enums;

namespace ManagingSoftwareProject.WebApi.Entities.Interfaces
{
    public interface IProduto
    {
        int Codigo { get; set; }
        string Descricao { get; set; }
        double Valor { get; set; }
        UnidadeMedida UnidadeMedida { get; set; }
        Agrupamento Agrupamento { get; set; }
    }
}
