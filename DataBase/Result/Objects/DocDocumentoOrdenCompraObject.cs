namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoOrdenCompraObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoOrdenCompra { get; set; } = null!;
    public string? TelefonoEntrega { get; set; }
    public string? DireccionEntrega { get; set; }
    public string? Asunto { get; set; }
    public string? Observaciones { get; set; }
    public DateTime FechaPagoFf { get; set; }
    public string? Solicitante { get; set; }
    public int IdFormaPago { get; set; }
    public int IdSucursal { get; set; }
}
