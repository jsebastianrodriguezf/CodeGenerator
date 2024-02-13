namespace SAMMAI.Transverse.Models.Objects;

public class ViewProActividadRecursoFisicoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ActividadRecursoFisico { get; set; } = null!;
    public string Duracion { get; set; } = null!;
    public int Cantidad { get; set; }
    public int IdRecursoFisico { get; set; }
    public string ProRecursoFisicoRecursoFisico { get; set; } = null!;
    public string? ProRecursoFisicoRecursoFisicoCodigo { get; set; }
    public double ProRecursoFisicoCosto { get; set; }
    public string ProRecursoFisicoUnidadTiempo { get; set; } = null!;
    public bool ProRecursoFisicoEsPropio { get; set; }
    public int ProRecursoFisicoIdEquipo { get; set; }
    public int ProRecursoFisicoIdCatalogo { get; set; }
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
