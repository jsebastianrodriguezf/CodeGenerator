namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepReporteCategorium : RepReporteCategoriumObject
{
    public virtual RepCategorium IdCategoriaNavigation { get; set; } = null!;
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
