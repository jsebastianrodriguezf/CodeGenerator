namespace SAMMAI.Transverse.Models.Objects;

public class SynPuntoIntegracionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PuntoIntegracion { get; set; } = null!;
    public string? PuntoIntegracionCodigo { get; set; }
    public string? TablaLocal { get; set; }
    public string? Condicion { get; set; }
    public string? UrlConsumir { get; set; }
    public int? IdPuntoIntegracion { get; set; }
    public int? IdSistemaIntegrar { get; set; }
    public string? Metodo { get; set; }
    public int? CantidadReintentos { get; set; }
    public int? IntervaloReintentos { get; set; }
    public string? CodigosReintentos { get; set; }
}
