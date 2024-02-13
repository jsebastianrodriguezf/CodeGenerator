namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Documento { get; set; } = null!;
    public string? DocumentoCodigo { get; set; }
    public int DocumentoNumero { get; set; }
    public string Prefijo { get; set; } = null!;
    public double Subtotal { get; set; }
    public double Descuento { get; set; }
    public double Iva { get; set; }
    public double Total { get; set; }
    public double Costo { get; set; }
    public double Rentabilidad { get; set; }
    public double Trm { get; set; }
    public DateTime FechaFh { get; set; }
    public DateTime FechaSugeridaFh { get; set; }
    public DateTime FechaCierreFf { get; set; }
    public DateTime FechaLimiteFh { get; set; }
    public int IdSubtipoDocumento { get; set; }
    public int IdTerceroCliente { get; set; }
    public int IdDocumento { get; set; }
    public int IdTerceroProveedor { get; set; }
    public int IdPrioridadDocumento { get; set; }
    public int IdMoneda { get; set; }
    public int IdEstadoTipoDocumento { get; set; }
    public int IdMotivoestado { get; set; }
    public double SubtotalPlaneado { get; set; }
    public double DescuentoPlaneado { get; set; }
    public double IvaPlaneado { get; set; }
    public double TotalPlaneado { get; set; }
    public double CostoPlaneado { get; set; }
    public int IdUsuarioAsignado { get; set; }
    public int IdUsuarioEnUso { get; set; }
}
