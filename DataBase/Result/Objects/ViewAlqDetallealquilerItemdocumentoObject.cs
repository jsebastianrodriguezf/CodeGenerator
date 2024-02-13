namespace SAMMAI.Transverse.Models.Objects;

public class ViewAlqDetallealquilerItemdocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetallealquilerItemdocumento { get; set; } = null!;
    public int IdDetallealquiler { get; set; }
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
    public int IdItemdocumento { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
