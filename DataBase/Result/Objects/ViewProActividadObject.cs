namespace SAMMAI.Transverse.Models.Objects;

public class ViewProActividadObject
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
    public string Multiempresa { get; set; } = null!;
}
