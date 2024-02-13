namespace SAMMAI.Transverse.Models.Objects;

public class ViewRepOpcionReporteObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string OpcionReporte { get; set; } = null!;
    public string? OpcionReporteCodigo { get; set; }
    public int IdReporte { get; set; }
    public string RepReporteReporte { get; set; } = null!;
    public string? RepReporteReporteCodigo { get; set; }
    public int RepReporteIdFuncionalidad { get; set; }
    public bool RepReporteEsFormato { get; set; }
    public bool RepReporteTieneGraficos { get; set; }
    public string RepReporteCabecera { get; set; } = null!;
    public bool Defecto { get; set; }
    public string Multiempresa { get; set; } = null!;
}
