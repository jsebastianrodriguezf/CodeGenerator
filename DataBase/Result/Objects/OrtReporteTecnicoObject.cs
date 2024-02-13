namespace SAMMAI.Transverse.Models.Objects;

public class OrtReporteTecnicoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ReporteTecnico { get; set; } = null!;
    public string? ReporteTecnicoCodigo { get; set; }
    public string? Numero { get; set; }
    public string? Trabajos { get; set; }
    public string? Recomendaciones { get; set; }
    public string? Compromisos { get; set; }
    public int IdGasto { get; set; }
    public int? IdCanalAtencion { get; set; }
    public string Diagnostico { get; set; } = null!;
    public int? IdDocumentoGasto { get; set; }
}
