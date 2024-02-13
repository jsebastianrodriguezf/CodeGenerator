using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProSesionActividad
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

    public string ProActividadActividad { get; set; } = null!;

    public string? ProActividadActividadCodigo { get; set; }

    public string ProActividadDescripcionDetallada { get; set; } = null!;

    public DateTime ProActividadFechainicioPlaneada { get; set; }

    public DateTime ProActividadFechainicioProyectada { get; set; }

    public DateTime ProActividadFechaInicioReal { get; set; }

    public string ProActividadDuracion { get; set; } = null!;

    public DateTime ProActividadFechaTerminacionPlaneada { get; set; }

    public DateTime ProActividadFechaTerminacionProyectada { get; set; }

    public DateTime ProActividadFechaTerminacionReal { get; set; }

    public int IdEjecutores { get; set; }

    public string ProEjecutoresEjecutores { get; set; } = null!;

    public string? ProEjecutoresEjecutoresCodigo { get; set; }

    public double ProEjecutoresCosto { get; set; }

    public string ProEjecutoresUnidadTiempo { get; set; } = null!;

    public int ProEjecutoresIdHorarioEjecutores { get; set; }

    public int ProEjecutoresIdUsuario { get; set; }

    public int IdGrupoSesion { get; set; }

    public string ProGrupoSesionGrupoSesion { get; set; } = null!;

    public string? ProGrupoSesionGrupoSesionCodigo { get; set; }

    public double Duracion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string Multiempresa { get; set; } = null!;
}
