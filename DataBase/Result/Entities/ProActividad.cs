namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProActividad : ProActividadObject
{
    public virtual ICollection<ProActividadEjecutor> ProActividadEjecutors { get; set; } = new List<ProActividadEjecutor>();
    public virtual ICollection<ProActividadEtapa> ProActividadEtapas { get; set; } = new List<ProActividadEtapa>();
    public virtual ICollection<ProActividadHito> ProActividadHitos { get; set; } = new List<ProActividadHito>();
    public virtual ICollection<ProActividadRecursoFisico> ProActividadRecursoFisicos { get; set; } = new List<ProActividadRecursoFisico>();
    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();
    public virtual ICollection<ProSesionActividad> ProSesionActividads { get; set; } = new List<ProSesionActividad>();
}
