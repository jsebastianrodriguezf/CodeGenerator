namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepCampoReporte : RepCampoReporteObject
{
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
    public virtual RepTipoCampoReporte IdTipoCampoReporteNavigation { get; set; } = null!;
}
