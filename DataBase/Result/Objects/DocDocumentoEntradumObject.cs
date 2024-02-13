namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoEntradumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoEntrada { get; set; } = null!;
    public string? TelefonoEntrega { get; set; }
    public string? DireccionEntrega { get; set; }
    public string? Asunto { get; set; }
    public string? Observaciones { get; set; }
    public string? Solicitante { get; set; }
    public int IdUsuarioRecibe { get; set; }
    public int IdTerceroTransportador { get; set; }
    public int IdSucursal { get; set; }
    public bool EsPorAjuste { get; set; }
}
