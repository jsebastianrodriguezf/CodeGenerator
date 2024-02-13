namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquPagoAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PagoAlquiler { get; set; } = null!;
    public string? PagoAlquilerCodigo { get; set; }
    public decimal ValorPorCobrar { get; set; }
    public decimal? ValorFacturado { get; set; }
    public string? NumeroFactura { get; set; }
    public DateTime FechaEsperadaPagoFf { get; set; }
    public DateTime? FechaFacturaFf { get; set; }
    public int IdDocumentoAlquiler { get; set; }
    public string DocDocumentoAlquilerDocumentoAlquiler { get; set; } = null!;
    public DateTime? DocDocumentoAlquilerFechaFinFf { get; set; }
    public bool DocDocumentoAlquilerMesVencido { get; set; }
    public string? DocDocumentoAlquilerObservaciones { get; set; }
    public string? DocDocumentoAlquilerDocumentoCodigo { get; set; }
    public int DocDocumentoAlquilerDocumentoNumero { get; set; }
    public string DocDocumentoAlquilerPrefijo { get; set; } = null!;
    public double DocDocumentoAlquilerSubtotal { get; set; }
    public double DocDocumentoAlquilerDescuento { get; set; }
    public double DocDocumentoAlquilerIva { get; set; }
    public double DocDocumentoAlquilerTotal { get; set; }
    public double DocDocumentoAlquilerCosto { get; set; }
    public double DocDocumentoAlquilerRentabilidad { get; set; }
    public double DocDocumentoAlquilerTrm { get; set; }
    public DateTime DocDocumentoAlquilerFechaFh { get; set; }
    public DateTime DocDocumentoAlquilerFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoAlquilerFechaCierreFf { get; set; }
    public DateTime DocDocumentoAlquilerFechaLimiteFh { get; set; }
    public int DocDocumentoAlquilerIdSubtipoDocumento { get; set; }
    public int DocDocumentoAlquilerIdTerceroCliente { get; set; }
    public int DocDocumentoAlquilerIdDocumento { get; set; }
    public int DocDocumentoAlquilerIdTerceroProveedor { get; set; }
    public int DocDocumentoAlquilerIdPrioridadDocumento { get; set; }
    public int DocDocumentoAlquilerIdMoneda { get; set; }
    public int DocDocumentoAlquilerIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoAlquilerIdMotivoestado { get; set; }
    public double DocDocumentoAlquilerSubtotalPlaneado { get; set; }
    public double DocDocumentoAlquilerDescuentoPlaneado { get; set; }
    public double DocDocumentoAlquilerIvaPlaneado { get; set; }
    public double DocDocumentoAlquilerTotalPlaneado { get; set; }
    public double DocDocumentoAlquilerCostoPlaneado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
