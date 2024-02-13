namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepTipoCampoReporte : RepTipoCampoReporteObject
{
    public virtual ICollection<RepCampoReporte> RepCampoReportes { get; set; } = new List<RepCampoReporte>();
}
