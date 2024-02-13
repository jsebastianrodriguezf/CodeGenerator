namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocItemDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ItemDocumento { get; set; } = null!;
    public string? ItemDocumentoCodigo { get; set; }
    public string Detalle { get; set; } = null!;
    public double HorasOrdinales { get; set; }
    public double HorasFestivas { get; set; }
    public double HorasNocturnas { get; set; }
    public double CantidadPlaneado { get; set; }
    public double CantidadEjecutado { get; set; }
    public decimal ValorUnitarioPlaneado { get; set; }
    public decimal ValorUnitarioEjecutado { get; set; }
    public decimal SubtotalPlaneado { get; set; }
    public decimal SubtotalEjecutado { get; set; }
    public decimal TotalPlaneado { get; set; }
    public decimal TotalEjecutado { get; set; }
    public double Porciva { get; set; }
    public decimal IvaPlaneado { get; set; }
    public decimal IvaEjecutado { get; set; }
    public double Porcdto { get; set; }
    public decimal DtoPlaneado { get; set; }
    public decimal DtoEjecutado { get; set; }
    public bool Costear { get; set; }
    public bool EsUrgente { get; set; }
    public DateTime? VencimientoGarantiaFf { get; set; }
    public double? HorasGarantia { get; set; }
    public double? PorcentajeCliente { get; set; }
    public double? PorcentajeDistribuidor { get; set; }
    public double? PorcentajeFabricante { get; set; }
    public bool AfectoInventario { get; set; }
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
    public string DocItemDocumentoPadreItemDocumento { get; set; } = null!;
    public string? DocItemDocumentoPadreItemDocumentoCodigo { get; set; }
    public string DocItemDocumentoPadreDetalle { get; set; } = null!;
    public double DocItemDocumentoPadreHorasOrdinales { get; set; }
    public double DocItemDocumentoPadreHorasFestivas { get; set; }
    public double DocItemDocumentoPadreHorasNocturnas { get; set; }
    public double DocItemDocumentoPadreCantidadPlaneado { get; set; }
    public double DocItemDocumentoPadreCantidadEjecutado { get; set; }
    public decimal DocItemDocumentoPadreValorUnitarioPlaneado { get; set; }
    public decimal DocItemDocumentoPadreValorUnitarioEjecutado { get; set; }
    public decimal DocItemDocumentoPadreSubtotalPlaneado { get; set; }
    public decimal DocItemDocumentoPadreSubtotalEjecutado { get; set; }
    public decimal DocItemDocumentoPadreTotalPlaneado { get; set; }
    public decimal DocItemDocumentoPadreTotalEjecutado { get; set; }
    public double DocItemDocumentoPadrePorciva { get; set; }
    public decimal DocItemDocumentoPadreIvaPlaneado { get; set; }
    public decimal DocItemDocumentoPadreIvaEjecutado { get; set; }
    public double DocItemDocumentoPadrePorcdto { get; set; }
    public decimal DocItemDocumentoPadreDtoPlaneado { get; set; }
    public decimal DocItemDocumentoPadreDtoEjecutado { get; set; }
    public bool DocItemDocumentoPadreCostear { get; set; }
    public bool DocItemDocumentoPadreEsUrgente { get; set; }
    public DateTime? DocItemDocumentoPadreVencimientoGarantiaFf { get; set; }
    public double? DocItemDocumentoPadreHorasGarantia { get; set; }
    public double? DocItemDocumentoPadrePorcentajeCliente { get; set; }
    public double? DocItemDocumentoPadrePorcentajeDistribuidor { get; set; }
    public double? DocItemDocumentoPadrePorcentajeFabricante { get; set; }
    public bool DocItemDocumentoPadreAfectoInventario { get; set; }
    public int DocItemDocumentoPadreIdDocumento { get; set; }
    public int DocItemDocumentoPadreIdItemDocumento { get; set; }
    public int DocItemDocumentoPadreIdCentroCosto { get; set; }
    public int DocItemDocumentoPadreIdCatalogo { get; set; }
    public int DocItemDocumentoPadreIdBodega { get; set; }
    public int DocItemDocumentoPadreIdIncoterm { get; set; }
    public int DocItemDocumentoPadreIdItemDocumentoSuperior { get; set; }
    public double DocItemDocumentoPadreCostoPlaneado { get; set; }
    public double DocItemDocumentoPadreCostoEjecutado { get; set; }
    public int DocItemDocumentoPadreIdListaprecio { get; set; }
    public double? DocItemDocumentoPadreVrbase { get; set; }
    public double? DocItemDocumentoPadreVrenlista { get; set; }
    public double? DocItemDocumentoPadrePorcdescuento { get; set; }
    public double DocItemDocumentoPadreCantAuxiliar { get; set; }
    public double? DocItemDocumentoPadrePorcentajeMargen { get; set; }
    public double? DocItemDocumentoPadreMargenPlaneado { get; set; }
    public int IdCentroCosto { get; set; }
    public string DocCentroCostoCentroCosto { get; set; } = null!;
    public string? DocCentroCostoCentroCostoCodigo { get; set; }
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
    public int IdBodega { get; set; }
    public string GenBodegaBodega { get; set; } = null!;
    public string? GenBodegaBodegaCodigo { get; set; }
    public bool GenBodegaSalidasEnRojo { get; set; }
    public bool GenBodegaUsaLocalizacion { get; set; }
    public int? GenBodegaIdSucursal { get; set; }
    public int IdIncoterm { get; set; }
    public string DocIncotermIncoterm { get; set; } = null!;
    public string? DocIncotermIncotermCodigo { get; set; }
    public int IdItemDocumentoSuperior { get; set; }
    public string DocItemDocumentoSuperiorItemDocumento { get; set; } = null!;
    public string? DocItemDocumentoSuperiorItemDocumentoCodigo { get; set; }
    public string DocItemDocumentoSuperiorDetalle { get; set; } = null!;
    public double DocItemDocumentoSuperiorHorasOrdinales { get; set; }
    public double DocItemDocumentoSuperiorHorasFestivas { get; set; }
    public double DocItemDocumentoSuperiorHorasNocturnas { get; set; }
    public double DocItemDocumentoSuperiorCantidadPlaneado { get; set; }
    public double DocItemDocumentoSuperiorCantidadEjecutado { get; set; }
    public decimal DocItemDocumentoSuperiorValorUnitarioPlaneado { get; set; }
    public decimal DocItemDocumentoSuperiorValorUnitarioEjecutado { get; set; }
    public decimal DocItemDocumentoSuperiorSubtotalPlaneado { get; set; }
    public decimal DocItemDocumentoSuperiorSubtotalEjecutado { get; set; }
    public decimal DocItemDocumentoSuperiorTotalPlaneado { get; set; }
    public decimal DocItemDocumentoSuperiorTotalEjecutado { get; set; }
    public double DocItemDocumentoSuperiorPorciva { get; set; }
    public decimal DocItemDocumentoSuperiorIvaPlaneado { get; set; }
    public decimal DocItemDocumentoSuperiorIvaEjecutado { get; set; }
    public double DocItemDocumentoSuperiorPorcdto { get; set; }
    public decimal DocItemDocumentoSuperiorDtoPlaneado { get; set; }
    public decimal DocItemDocumentoSuperiorDtoEjecutado { get; set; }
    public bool DocItemDocumentoSuperiorCostear { get; set; }
    public bool DocItemDocumentoSuperiorEsUrgente { get; set; }
    public DateTime? DocItemDocumentoSuperiorVencimientoGarantiaFf { get; set; }
    public double? DocItemDocumentoSuperiorHorasGarantia { get; set; }
    public double? DocItemDocumentoSuperiorPorcentajeCliente { get; set; }
    public double? DocItemDocumentoSuperiorPorcentajeDistribuidor { get; set; }
    public double? DocItemDocumentoSuperiorPorcentajeFabricante { get; set; }
    public bool DocItemDocumentoSuperiorAfectoInventario { get; set; }
    public int DocItemDocumentoSuperiorIdDocumento { get; set; }
    public int DocItemDocumentoSuperiorIdItemDocumento { get; set; }
    public int DocItemDocumentoSuperiorIdCentroCosto { get; set; }
    public int DocItemDocumentoSuperiorIdCatalogo { get; set; }
    public int DocItemDocumentoSuperiorIdBodega { get; set; }
    public int DocItemDocumentoSuperiorIdIncoterm { get; set; }
    public int DocItemDocumentoSuperiorIdItemDocumentoSuperior { get; set; }
    public double DocItemDocumentoSuperiorCostoPlaneado { get; set; }
    public double DocItemDocumentoSuperiorCostoEjecutado { get; set; }
    public int DocItemDocumentoSuperiorIdListaprecio { get; set; }
    public double? DocItemDocumentoSuperiorVrbase { get; set; }
    public double? DocItemDocumentoSuperiorVrenlista { get; set; }
    public double? DocItemDocumentoSuperiorPorcdescuento { get; set; }
    public double DocItemDocumentoSuperiorCantAuxiliar { get; set; }
    public double? DocItemDocumentoSuperiorPorcentajeMargen { get; set; }
    public double? DocItemDocumentoSuperiorMargenPlaneado { get; set; }
    public double CostoPlaneado { get; set; }
    public double CostoEjecutado { get; set; }
    public int IdListaprecio { get; set; }
    public string CatListaPrecioListaPrecio { get; set; } = null!;
    public string? CatListaPrecioListaPrecioCodigo { get; set; }
    public double CatListaPrecioPorcentajeDescuento { get; set; }
    public bool CatListaPrecioEsPrivado { get; set; }
    public int CatListaPrecioIdMoneda { get; set; }
    public bool? CatListaPrecioParaCompra { get; set; }
    public double? Vrbase { get; set; }
    public double? Vrenlista { get; set; }
    public double? Porcdescuento { get; set; }
    public double CantAuxiliar { get; set; }
    public double? PorcentajeMargen { get; set; }
    public double? MargenPlaneado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
