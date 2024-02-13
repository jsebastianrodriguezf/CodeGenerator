namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProEjecutore : ProEjecutoreObject
{
    public virtual ICollection<DocDocumentoProyectoEjecutore> DocDocumentoProyectoEjecutores { get; set; } = new List<DocDocumentoProyectoEjecutore>();
    public virtual ProHorarioEjecutore IdHorarioEjecutoresNavigation { get; set; } = null!;
    public virtual ProHorarioTrabajo IdHorarioTrabajoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<ProActividadEjecutor> ProActividadEjecutors { get; set; } = new List<ProActividadEjecutor>();
    public virtual ICollection<ProEjecutoresArchivo> ProEjecutoresArchivos { get; set; } = new List<ProEjecutoresArchivo>();
    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();
    public virtual ICollection<ProSesionActividad> ProSesionActividads { get; set; } = new List<ProSesionActividad>();
}
