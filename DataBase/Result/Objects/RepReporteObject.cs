namespace SAMMAI.Transverse.Models.Objects;

public class RepReporteObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Reporte { get; set; } = null!;
    public string? ReporteCodigo { get; set; }
    public int IdFuncionalidad { get; set; }
    public bool EsFormato { get; set; }
    public bool TieneGraficos { get; set; }
    public string Cabecera { get; set; } = null!;
    public int Orden { get; set; }
    public bool Basica { get; set; }
}
