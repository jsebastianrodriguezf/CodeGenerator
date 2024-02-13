using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProSesionActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SesionActividad { get; set; } = null!;

    public string? SesionActividadCodigo { get; set; }

    public int IdActividad { get; set; }

    public int IdEjecutores { get; set; }

    public int IdGrupoSesion { get; set; }

    public double Duracion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public virtual ProActividad IdActividadNavigation { get; set; } = null!;

    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;

    public virtual ProGrupoSesion IdGrupoSesionNavigation { get; set; } = null!;

    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();
}
