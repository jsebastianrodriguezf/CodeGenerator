namespace SAMMAI.Transverse.Models.Objects;

public class ViewGasDetalleGastoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleGasto { get; set; } = null!;
    public string? DetalleGastoCodigo { get; set; }
    public DateTime FechaFf { get; set; }
    public double Valor { get; set; }
    public double Cantidad { get; set; }
    public int IdGasto { get; set; }
    public string GasGastoGasto { get; set; } = null!;
    public string? GasGastoGastoCodigo { get; set; }
    public int GasGastoNumero { get; set; }
    public DateTime GasGastoFechaFf { get; set; }
    public int GasGastoDias { get; set; }
    public double GasGastoValor { get; set; }
    public string GasGastoConcepto { get; set; } = null!;
    public bool GasGastoConsignado { get; set; }
    public int GasGastoIdTipoGasto { get; set; }
    public int GasGastoIdUsuarioAprobo { get; set; }
    public int GasGastoIdUsuarioSolicitante { get; set; }
    public int GasGastoIdEstadoTipoDocumento { get; set; }
    public int IdCatalogo { get; set; }
    public string CatCatalogoCatalogo { get; set; } = null!;
    public string? CatCatalogoCatalogoCodigo { get; set; }
    public string CatCatalogoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoPrecioVenta { get; set; }
    public int? CatCatalogoTiempoConsecucion { get; set; }
    public bool CatCatalogoEsNacional { get; set; }
    public int CatCatalogoIdFamilia { get; set; }
    public int CatCatalogoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoIdUnidad { get; set; }
    public int CatCatalogoIdImpuesto { get; set; }
    public string CatCatalogoDescripcion { get; set; } = null!;
    public bool CatCatalogoBloquearCostear { get; set; }
    public int IdDocumentoGasto { get; set; }
    public string DocDocumentoGastoDocumentoGasto { get; set; } = null!;
    public DateTime DocDocumentoGastoFechaFf { get; set; }
    public int DocDocumentoGastoDias { get; set; }
    public string DocDocumentoGastoConcepto { get; set; } = null!;
    public bool DocDocumentoGastoConsignado { get; set; }
    public string? DocDocumentoGastoDocumentoCodigo { get; set; }
    public int DocDocumentoGastoDocumentoNumero { get; set; }
    public string DocDocumentoGastoPrefijo { get; set; } = null!;
    public double DocDocumentoGastoSubtotal { get; set; }
    public double DocDocumentoGastoDescuento { get; set; }
    public double DocDocumentoGastoIva { get; set; }
    public double DocDocumentoGastoTotal { get; set; }
    public double DocDocumentoGastoCosto { get; set; }
    public double DocDocumentoGastoRentabilidad { get; set; }
    public double DocDocumentoGastoTrm { get; set; }
    public DateTime DocDocumentoGastoFechaFh { get; set; }
    public DateTime DocDocumentoGastoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoGastoFechaCierreFf { get; set; }
    public DateTime DocDocumentoGastoFechaLimiteFh { get; set; }
    public int DocDocumentoGastoIdSubtipoDocumento { get; set; }
    public int DocDocumentoGastoIdTerceroCliente { get; set; }
    public int DocDocumentoGastoIdDocumento { get; set; }
    public int DocDocumentoGastoIdTerceroProveedor { get; set; }
    public int DocDocumentoGastoIdPrioridadDocumento { get; set; }
    public int DocDocumentoGastoIdMoneda { get; set; }
    public int DocDocumentoGastoIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoGastoIdMotivoestado { get; set; }
    public double DocDocumentoGastoSubtotalPlaneado { get; set; }
    public double DocDocumentoGastoDescuentoPlaneado { get; set; }
    public double DocDocumentoGastoIvaPlaneado { get; set; }
    public double DocDocumentoGastoTotalPlaneado { get; set; }
    public double DocDocumentoGastoCostoPlaneado { get; set; }
    public int DocDocumentoGastoIdUsuarioAsignado { get; set; }
    public int DocDocumentoGastoIdUsuarioEnUso { get; set; }
    public string Multiempresa { get; set; } = null!;
}
