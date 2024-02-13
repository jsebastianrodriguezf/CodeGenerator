using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProEjecutore
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Ejecutores { get; set; } = null!;

    public string? EjecutoresCodigo { get; set; }

    public double Costo { get; set; }

    public string UnidadTiempo { get; set; } = null!;

    public int IdHorarioTrabajo { get; set; }

    public int IdUsuario { get; set; }

    public int IdHorarioEjecutores { get; set; }

    public virtual ICollection<DocDocumentoProyectoEjecutore> DocDocumentoProyectoEjecutores { get; set; } = new List<DocDocumentoProyectoEjecutore>();

    public virtual ProHorarioEjecutore IdHorarioEjecutoresNavigation { get; set; } = null!;

    public virtual ProHorarioTrabajo IdHorarioTrabajoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<ProActividadEjecutor> ProActividadEjecutors { get; set; } = new List<ProActividadEjecutor>();

    public virtual ICollection<ProEjecutoresArchivo> ProEjecutoresArchivos { get; set; } = new List<ProEjecutoresArchivo>();

    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();

    public virtual ICollection<ProSesionActividad> ProSesionActividads { get; set; } = new List<ProSesionActividad>();
}
