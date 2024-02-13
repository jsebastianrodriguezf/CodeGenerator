using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Actividad { get; set; } = null!;

    public string? ActividadCodigo { get; set; }

    public string DescripcionDetallada { get; set; } = null!;

    public DateTime FechainicioPlaneada { get; set; }

    public DateTime FechainicioProyectada { get; set; }

    public DateTime FechaInicioReal { get; set; }

    public string Duracion { get; set; } = null!;

    public DateTime FechaTerminacionPlaneada { get; set; }

    public DateTime FechaTerminacionProyectada { get; set; }

    public DateTime FechaTerminacionReal { get; set; }

    public virtual ICollection<ProActividadEjecutor> ProActividadEjecutors { get; set; } = new List<ProActividadEjecutor>();

    public virtual ICollection<ProActividadEtapa> ProActividadEtapas { get; set; } = new List<ProActividadEtapa>();

    public virtual ICollection<ProActividadHito> ProActividadHitos { get; set; } = new List<ProActividadHito>();

    public virtual ICollection<ProActividadRecursoFisico> ProActividadRecursoFisicos { get; set; } = new List<ProActividadRecursoFisico>();

    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();

    public virtual ICollection<ProSesionActividad> ProSesionActividads { get; set; } = new List<ProSesionActividad>();
}
