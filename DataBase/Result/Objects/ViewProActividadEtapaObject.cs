namespace SAMMAI.Transverse.Models.Objects;

public class ViewProActividadEtapaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ActividadEtapa { get; set; } = null!;
    public int IdEtapa { get; set; }
    public string ProEtapaEtapa { get; set; } = null!;
    public string? ProEtapaEtapaCodigo { get; set; }
    public string ProEtapaDescripcion { get; set; } = null!;
    public DateTime ProEtapaFechaInicioPlaneadaFf { get; set; }
    public DateTime? ProEtapaFechaInicioProyectadaFf { get; set; }
    public DateTime? ProEtapaFechaInicioRealFf { get; set; }
    public DateTime ProEtapaFechaFinPlaneadaFf { get; set; }
    public DateTime? ProEtapaFechaFinProyectadaFf { get; set; }
    public DateTime? ProEtapaFechaFinRealFf { get; set; }
    public int? ProEtapaOrden { get; set; }
    public int? ProEtapaCompletado { get; set; }
    public double? ProEtapaPorcentajePresupuesto { get; set; }
    public decimal? ProEtapaValorPresupuesto { get; set; }
    public DateTime ProEtapaFechaInicioPlaneada { get; set; }
    public DateTime? ProEtapaFechaInicioProyectada { get; set; }
    public DateTime? ProEtapaFechaInicioReal { get; set; }
    public DateTime ProEtapaFechaFinPlaneada { get; set; }
    public DateTime? ProEtapaFechaFinProyectada { get; set; }
    public DateTime? ProEtapaFechaFinReal { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
