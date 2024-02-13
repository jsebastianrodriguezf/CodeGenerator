namespace SAMMAI.Transverse.Models.Objects;

public class SynCampoIntegracionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CampoIntegracion { get; set; } = null!;
    public string? CampoIntegracionCodigo { get; set; }
    public string? CampoLocal { get; set; }
    public string? TablaAuxiliar { get; set; }
    public string? CampoEnlace { get; set; }
    public string? ValorXdefecto { get; set; }
    public int? TipoDato { get; set; }
    public int? Longitud { get; set; }
    public bool? EsLlave { get; set; }
    public int? Orden { get; set; }
    public int? IdPuntoIntegracion { get; set; }
}
