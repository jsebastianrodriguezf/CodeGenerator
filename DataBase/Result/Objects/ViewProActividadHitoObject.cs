namespace SAMMAI.Transverse.Models.Objects;

public class ViewProActividadHitoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ActividadHito { get; set; } = null!;
    public int IdHito { get; set; }
    public string ProHitoHito { get; set; } = null!;
    public string? ProHitoHitoCodigo { get; set; }
    public int ProHitoIdDocumentoProyecto { get; set; }
    public int IdActividad { get; set; }
    public string ProActividadActividad { get; set; } = null!;
    public string? ProActividadActividadCodigo { get; set; }
    public DateTime ProActividadFechainicioPlaneada { get; set; }
    public DateTime ProActividadFechainicioProyectada { get; set; }
    public DateTime ProActividadFechaInicioReal { get; set; }
    public DateTime ProActividadFechaTerminacionPlaneada { get; set; }
    public DateTime ProActividadFechaTerminacionProyectada { get; set; }
    public DateTime ProActividadFechaTerminacionReal { get; set; }
    public string ProActividadDescripcionDetallada { get; set; } = null!;
    public string ProActividadDuracion { get; set; } = null!;
    public string Multiempresa { get; set; } = null!;
}
