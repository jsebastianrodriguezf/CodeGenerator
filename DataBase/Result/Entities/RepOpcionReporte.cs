namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepOpcionReporte : RepOpcionReporteObject
{
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
