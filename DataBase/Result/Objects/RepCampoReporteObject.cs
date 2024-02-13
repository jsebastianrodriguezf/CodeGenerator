namespace SAMMAI.Transverse.Models.Objects;

public class RepCampoReporteObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CampoReporte { get; set; } = null!;
    public string? CampoReporteCodigo { get; set; }
    public int IdReporte { get; set; }
    public int IdTipoCampoReporte { get; set; }
    public string Tabla { get; set; } = null!;
    public string ValorDefecto { get; set; } = null!;
    public bool EsParametro { get; set; }
    public bool EsSerie { get; set; }
    public bool ParametroTotal { get; set; }
}
