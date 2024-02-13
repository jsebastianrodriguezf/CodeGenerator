namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProReporteActividad : ProReporteActividadObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
    public virtual ProSesionActividad IdSesionActividadNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
