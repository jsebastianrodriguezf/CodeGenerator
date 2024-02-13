namespace SAMMAI.Transverse.Models.Objects;

public class GenDetalleFormularioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleFormulario { get; set; } = null!;
    public string? DetalleFormularioCodigo { get; set; }
    public string Defecto { get; set; } = null!;
    public bool EsObligatorio { get; set; }
    public int Orden { get; set; }
    public int IdTipoDato { get; set; }
    public int? IdColumna { get; set; }
    public int IdFormulario { get; set; }
}
