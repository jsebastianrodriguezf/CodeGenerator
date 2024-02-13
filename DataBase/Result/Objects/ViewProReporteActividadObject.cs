namespace SAMMAI.Transverse.Models.Objects;

public class ViewProReporteActividadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ReporteActividad { get; set; } = null!;
    public string? ReporteActividadCodigo { get; set; }
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
    public int IdSesionActividad { get; set; }
    public string ProSesionActividadSesionActividad { get; set; } = null!;
    public string? ProSesionActividadSesionActividadCodigo { get; set; }
    public int ProSesionActividadIdActividad { get; set; }
    public int ProSesionActividadIdEjecutores { get; set; }
    public int ProSesionActividadIdGrupoSesion { get; set; }
    public double ProSesionActividadDuracion { get; set; }
    public string? ProSesionActividadDescripcion { get; set; }
    public DateTime? ProSesionActividadFechaInicio { get; set; }
    public int IdEjecutores { get; set; }
    public string ProEjecutoresEjecutores { get; set; } = null!;
    public string? ProEjecutoresEjecutoresCodigo { get; set; }
    public double ProEjecutoresCosto { get; set; }
    public string ProEjecutoresUnidadTiempo { get; set; } = null!;
    public int ProEjecutoresIdHorarioEjecutores { get; set; }
    public int ProEjecutoresIdUsuario { get; set; }
    public int IdSucursal { get; set; }
    public string TerSucursalSucursal { get; set; } = null!;
    public string? TerSucursalSucursalCodigo { get; set; }
    public string? TerSucursalContacto { get; set; }
    public string TerSucursalTelefono { get; set; } = null!;
    public string? TerSucursalFax { get; set; }
    public string? TerSucursalEmail { get; set; }
    public string? TerSucursalDireccion { get; set; }
    public bool TerSucursalParaVenta { get; set; }
    public bool TerSucursalParaSoporte { get; set; }
    public bool TerSucursalParaAlquiler { get; set; }
    public int TerSucursalIdTercero { get; set; }
    public int TerSucursalIdZona { get; set; }
    public int TerSucursalIdUsuarioAsesor { get; set; }
    public int TerSucursalIdUsuarioTecnico { get; set; }
    public int TerSucursalIdSucursal { get; set; }
    public int TerSucursalIdEstadoTercero { get; set; }
    public string? TerSucursalCodigorecursiva { get; set; }
    public DateTime? FechaInicio { get; set; }
    public double? Duracion { get; set; }
    public string? Texto { get; set; }
    public double? PorcentajeAvance { get; set; }
    public string Multiempresa { get; set; } = null!;
}
