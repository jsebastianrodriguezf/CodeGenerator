namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProSesionActividad : ProSesionActividadObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
    public virtual ProGrupoSesion IdGrupoSesionNavigation { get; set; } = null!;
    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();
}
