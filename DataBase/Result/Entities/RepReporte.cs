namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepReporte : RepReporteObject
{
    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();
    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;
    public virtual ICollection<RepCampoReporte> RepCampoReportes { get; set; } = new List<RepCampoReporte>();
    public virtual ICollection<RepIndicador> RepIndicadors { get; set; } = new List<RepIndicador>();
    public virtual ICollection<RepOpcionReporte> RepOpcionReportes { get; set; } = new List<RepOpcionReporte>();
    public virtual ICollection<RepOrigenDato> RepOrigenDatos { get; set; } = new List<RepOrigenDato>();
    public virtual ICollection<RepReporteCategorium> RepReporteCategoria { get; set; } = new List<RepReporteCategorium>();
}
