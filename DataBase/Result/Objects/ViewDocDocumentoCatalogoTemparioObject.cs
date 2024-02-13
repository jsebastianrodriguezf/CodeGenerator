namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoCatalogoTemparioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoCatalogoTempario { get; set; } = null!;
    public int IdCatalogoTempario { get; set; }
    public string CatCatalogoTemparioCatalogoTempario { get; set; } = null!;
    public double? CatCatalogoTemparioDuracionEstimada { get; set; }
    public bool CatCatalogoTemparioEnTaller { get; set; }
    public bool CatCatalogoTemparioEsCiclico { get; set; }
    public bool CatCatalogoTemparioDetieneEquipos { get; set; }
    public double? CatCatalogoTemparioHorasDetencion { get; set; }
    public int CatCatalogoTemparioPeriodoHoras { get; set; }
    public bool CatCatalogoTemparioFacturaTodo { get; set; }
    public int CatCatalogoTemparioPeriodoDias { get; set; }
    public double CatCatalogoTemparioPorcGarantia { get; set; }
    public double CatCatalogoTemparioPorcTropicalizacion { get; set; }
    public int CatCatalogoTemparioIdTipoServicio { get; set; }
    public bool CatCatalogoTemparioProyectar { get; set; }
    public bool CatCatalogoTemparioIncluirMenores { get; set; }
    public int CatCatalogoTemparioModoAjuste { get; set; }
    public string? CatCatalogoTemparioCatalogoCodigo { get; set; }
    public string CatCatalogoTemparioCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoTemparioPrecioVenta { get; set; }
    public int? CatCatalogoTemparioTiempoConsecucion { get; set; }
    public bool CatCatalogoTemparioEsNacional { get; set; }
    public int CatCatalogoTemparioIdFamilia { get; set; }
    public int CatCatalogoTemparioIdSubtipoCatalogo { get; set; }
    public int CatCatalogoTemparioIdUnidad { get; set; }
    public int CatCatalogoTemparioIdImpuesto { get; set; }
    public string CatCatalogoTemparioDescripcion { get; set; } = null!;
    public bool CatCatalogoTemparioBloquearCostear { get; set; }
    public int IdDocumento { get; set; }
    public string DocDocumentoDocumento { get; set; } = null!;
    public string? DocDocumentoDocumentoCodigo { get; set; }
    public int DocDocumentoDocumentoNumero { get; set; }
    public string DocDocumentoPrefijo { get; set; } = null!;
    public double DocDocumentoSubtotal { get; set; }
    public double DocDocumentoDescuento { get; set; }
    public double DocDocumentoIva { get; set; }
    public double DocDocumentoTotal { get; set; }
    public double DocDocumentoCosto { get; set; }
    public double DocDocumentoRentabilidad { get; set; }
    public double DocDocumentoTrm { get; set; }
    public DateTime DocDocumentoFechaFh { get; set; }
    public DateTime DocDocumentoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoFechaCierreFf { get; set; }
    public DateTime DocDocumentoFechaLimiteFh { get; set; }
    public int DocDocumentoIdSubtipoDocumento { get; set; }
    public int DocDocumentoIdTerceroCliente { get; set; }
    public int DocDocumentoIdDocumento { get; set; }
    public int DocDocumentoIdTerceroProveedor { get; set; }
    public int DocDocumentoIdPrioridadDocumento { get; set; }
    public int DocDocumentoIdMoneda { get; set; }
    public int DocDocumentoIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoIdMotivoestado { get; set; }
    public double DocDocumentoSubtotalPlaneado { get; set; }
    public double DocDocumentoDescuentoPlaneado { get; set; }
    public double DocDocumentoIvaPlaneado { get; set; }
    public double DocDocumentoTotalPlaneado { get; set; }
    public double DocDocumentoCostoPlaneado { get; set; }
    public int DocDocumentoIdUsuarioAsignado { get; set; }
    public int DocDocumentoIdUsuarioEnUso { get; set; }
    public int IdItemDocumento { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
