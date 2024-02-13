namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepCategorium : RepCategoriumObject
{
    public virtual RepCategorium IdCategoriaNavigation { get; set; } = null!;
    public virtual ICollection<RepCategorium> InverseIdCategoriaNavigation { get; set; } = new List<RepCategorium>();
    public virtual ICollection<RepReporteCategorium> RepReporteCategoria { get; set; } = new List<RepReporteCategorium>();
}
