namespace SAMMAI.Transverse.Models.Objects;

public class RepIndicadorObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Indicador { get; set; } = null!;
    public string? IndicadorCodigo { get; set; }
    public int IdReporte { get; set; }
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; }
    public string? Cabecera { get; set; }
    public string? Seccion1 { get; set; }
    public string? Seccion2 { get; set; }
    public string? Seccion3 { get; set; }
    public string? Seccion4 { get; set; }
    public string? Seccion5 { get; set; }
    public string? Seccion6 { get; set; }
    public string? Seccion7 { get; set; }
    public string? Seccion8 { get; set; }
}
