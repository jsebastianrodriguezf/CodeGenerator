namespace SAMMAI.Transverse.Models.Objects;

public class ViewAlqDetalleLiquidacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleLiquidacion { get; set; } = null!;
    public string? DetalleLiquidacionCodigo { get; set; }
    public int? Cantidad { get; set; }
    public int? Dias { get; set; }
    public DateTime? FechaInicioFh { get; set; }
    public DateTime? FechaFinFh { get; set; }
    public int? IdItemDocumento { get; set; }
    public string DocItemDocumentoItemDocumento { get; set; } = null!;
    public string? DocItemDocumentoItemDocumentoCodigo { get; set; }
    public string DocItemDocumentoDetalle { get; set; } = null!;
    public double DocItemDocumentoHorasOrdinales { get; set; }
    public double DocItemDocumentoHorasFestivas { get; set; }
    public double DocItemDocumentoHorasNocturnas { get; set; }
    public double DocItemDocumentoCantidadPlaneado { get; set; }
    public double DocItemDocumentoCantidadEjecutado { get; set; }
    public decimal DocItemDocumentoValorUnitarioPlaneado { get; set; }
    public decimal DocItemDocumentoValorUnitarioEjecutado { get; set; }
    public decimal DocItemDocumentoSubtotalPlaneado { get; set; }
    public decimal DocItemDocumentoSubtotalEjecutado { get; set; }
    public decimal DocItemDocumentoTotalPlaneado { get; set; }
    public decimal DocItemDocumentoTotalEjecutado { get; set; }
    public double DocItemDocumentoPorciva { get; set; }
    public decimal DocItemDocumentoIvaPlaneado { get; set; }
    public decimal DocItemDocumentoIvaEjecutado { get; set; }
    public double DocItemDocumentoPorcdto { get; set; }
    public decimal DocItemDocumentoDtoPlaneado { get; set; }
    public decimal DocItemDocumentoDtoEjecutado { get; set; }
    public bool DocItemDocumentoCostear { get; set; }
    public bool DocItemDocumentoEsUrgente { get; set; }
    public DateTime? DocItemDocumentoVencimientoGarantiaFf { get; set; }
    public double? DocItemDocumentoHorasGarantia { get; set; }
    public double? DocItemDocumentoPorcentajeCliente { get; set; }
    public double? DocItemDocumentoPorcentajeDistribuidor { get; set; }
    public double? DocItemDocumentoPorcentajeFabricante { get; set; }
    public bool DocItemDocumentoAfectoInventario { get; set; }
    public int DocItemDocumentoIdDocumento { get; set; }
    public int DocItemDocumentoIdItemDocumento { get; set; }
    public int DocItemDocumentoIdCentroCosto { get; set; }
    public int DocItemDocumentoIdCatalogo { get; set; }
    public int DocItemDocumentoIdBodega { get; set; }
    public int DocItemDocumentoIdIncoterm { get; set; }
    public int DocItemDocumentoIdItemDocumentoSuperior { get; set; }
    public double DocItemDocumentoCostoPlaneado { get; set; }
    public double DocItemDocumentoCostoEjecutado { get; set; }
    public int DocItemDocumentoIdListaprecio { get; set; }
    public double? DocItemDocumentoVrbase { get; set; }
    public double? DocItemDocumentoVrenlista { get; set; }
    public double? DocItemDocumentoPorcdescuento { get; set; }
    public double DocItemDocumentoCantAuxiliar { get; set; }
    public int? IdDetalleAlquiler { get; set; }
    public string EquDetalleAlquilerDetalleAlquiler { get; set; } = null!;
    public string? EquDetalleAlquilerDetalleAlquilerCodigo { get; set; }
    public DateTime EquDetalleAlquilerFechaDevolucionFf { get; set; }
    public decimal EquDetalleAlquilerValorHora { get; set; }
    public decimal EquDetalleAlquilerValorHoraStandBy { get; set; }
    public decimal EquDetalleAlquilerValorPeriodo { get; set; }
    public decimal EquDetalleAlquilerValorMulta { get; set; }
    public DateTime EquDetalleAlquilerFechaDespachoFf { get; set; }
    public int EquDetalleAlquilerIdEquipo { get; set; }
    public int EquDetalleAlquilerIdDocumentoAlquiler { get; set; }
    public int EquDetalleAlquilerIdSucursal { get; set; }
    public int EquDetalleAlquilerIdTercero { get; set; }
    public DateTime? EquDetalleAlquilerFechaUltimaFacturaFh { get; set; }
    public double? EquDetalleAlquilerValorMes { get; set; }
    public DateTime EquDetalleAlquilerFechaInicioFacturaFh { get; set; }
    public int EquDetalleAlquilerCantidadSolicitada { get; set; }
    public int EquDetalleAlquilerCantidadAlquilada { get; set; }
    public int EquDetalleAlquilerIdCatalogo { get; set; }
    public int? EquDetalleAlquilerEstadoalquiler { get; set; }
    public bool EquDetalleAlquilerEsSerializado { get; set; }
    public bool EquDetalleAlquilerBloquearDespacho { get; set; }
    public int? Saldo { get; set; }
    public int? IdDocumentoMovimiento { get; set; }
    public string DocDocumentoMovimientoDocumento { get; set; } = null!;
    public string? DocDocumentoMovimientoDocumentoCodigo { get; set; }
    public int DocDocumentoMovimientoDocumentoNumero { get; set; }
    public string DocDocumentoMovimientoPrefijo { get; set; } = null!;
    public double DocDocumentoMovimientoSubtotal { get; set; }
    public double DocDocumentoMovimientoDescuento { get; set; }
    public double DocDocumentoMovimientoIva { get; set; }
    public double DocDocumentoMovimientoTotal { get; set; }
    public double DocDocumentoMovimientoCosto { get; set; }
    public double DocDocumentoMovimientoRentabilidad { get; set; }
    public double DocDocumentoMovimientoTrm { get; set; }
    public DateTime DocDocumentoMovimientoFechaFh { get; set; }
    public DateTime DocDocumentoMovimientoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoMovimientoFechaCierreFf { get; set; }
    public DateTime DocDocumentoMovimientoFechaLimiteFh { get; set; }
    public int DocDocumentoMovimientoIdSubtipoDocumento { get; set; }
    public int DocDocumentoMovimientoIdTerceroCliente { get; set; }
    public int DocDocumentoMovimientoIdDocumento { get; set; }
    public int DocDocumentoMovimientoIdTerceroProveedor { get; set; }
    public int DocDocumentoMovimientoIdPrioridadDocumento { get; set; }
    public int DocDocumentoMovimientoIdMoneda { get; set; }
    public int DocDocumentoMovimientoIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoMovimientoIdMotivoestado { get; set; }
    public double DocDocumentoMovimientoSubtotalPlaneado { get; set; }
    public double DocDocumentoMovimientoDescuentoPlaneado { get; set; }
    public double DocDocumentoMovimientoIvaPlaneado { get; set; }
    public double DocDocumentoMovimientoTotalPlaneado { get; set; }
    public double DocDocumentoMovimientoCostoPlaneado { get; set; }
    public double? Horometro { get; set; }
    public int? IdTarifa { get; set; }
    public int IdEvento { get; set; }
    public string DisEventoEvento { get; set; } = null!;
    public string? DisEventoEventoCodigo { get; set; }
    public DateTime DisEventoFechaHoraInicioFf { get; set; }
    public DateTime DisEventoDuracionHh { get; set; }
    public bool DisEventoAfectaProduccion { get; set; }
    public string? DisEventoNotas { get; set; }
    public int DisEventoIdEquipo { get; set; }
    public int DisEventoIdMotivoEvento { get; set; }
    public int DisEventoIdUsuario { get; set; }
    public int DisEventoIdEstadoEquipo { get; set; }
    public int DisEventoIdFalla { get; set; }
    public int DisEventoIdFallaCausa { get; set; }
    public int DisEventoIdMetodoDeteccion { get; set; }
    public DateTime DisEventoFechaHoraEstimadaFh { get; set; }
    public int DisEventoEventoTipo { get; set; }
    public bool DisEventoAfectaCliente { get; set; }
    public int DisEventoIdEstadoEvento { get; set; }
    public string? DisEventoCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
