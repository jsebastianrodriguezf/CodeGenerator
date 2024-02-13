namespace SAMMAI.Transverse.Models.Objects;

public class ProEtapaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Etapa { get; set; } = null!;
    public string? EtapaCodigo { get; set; }
    public string Descripcion { get; set; } = null!;
    public DateTime FechaInicioPlaneadaFf { get; set; }
    public DateTime? FechaInicioProyectadaFf { get; set; }
    public DateTime? FechaInicioRealFf { get; set; }
    public DateTime FechaFinPlaneadaFf { get; set; }
    public DateTime? FechaFinProyectadaFf { get; set; }
    public DateTime? FechaFinRealFf { get; set; }
    public int? Orden { get; set; }
    public int? Completado { get; set; }
    public double? PorcentajePresupuesto { get; set; }
    public decimal? ValorPresupuesto { get; set; }
    public DateTime FechaInicioPlaneada { get; set; }
    public DateTime? FechaInicioProyectada { get; set; }
    public DateTime? FechaInicioReal { get; set; }
    public DateTime FechaFinPlaneada { get; set; }
    public DateTime? FechaFinProyectada { get; set; }
    public DateTime? FechaFinReal { get; set; }
}
