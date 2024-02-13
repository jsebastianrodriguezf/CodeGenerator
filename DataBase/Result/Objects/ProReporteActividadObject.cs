namespace SAMMAI.Transverse.Models.Objects;

public class ProReporteActividadObject
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
    public int IdSesionActividad { get; set; }
    public int IdEjecutores { get; set; }
    public int IdSucursal { get; set; }
    public DateTime? FechaInicio { get; set; }
    public double? Duracion { get; set; }
    public string? Texto { get; set; }
    public double? PorcentajeAvance { get; set; }
}
