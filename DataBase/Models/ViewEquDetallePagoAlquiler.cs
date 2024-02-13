using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquDetallePagoAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetallePagoAlquiler { get; set; } = null!;

    public string? DetallePagoAlquilerCodigo { get; set; }

    public decimal Valor { get; set; }

    public double? Horometro { get; set; }

    public int IdPagoAlquiler { get; set; }

    public string EquPagoAlquilerPagoAlquiler { get; set; } = null!;

    public string? EquPagoAlquilerPagoAlquilerCodigo { get; set; }

    public decimal EquPagoAlquilerValorPorCobrar { get; set; }

    public decimal? EquPagoAlquilerValorFacturado { get; set; }

    public string? EquPagoAlquilerNumeroFactura { get; set; }

    public DateTime EquPagoAlquilerFechaEsperadaPagoFf { get; set; }

    public DateTime? EquPagoAlquilerFechaFacturaFf { get; set; }

    public int EquPagoAlquilerIdDocumentoAlquiler { get; set; }

    public int IdEquipo { get; set; }

    public string EquEquipoEquipo { get; set; } = null!;

    public string? EquEquipoEquipoCodigo { get; set; }

    public string EquEquipoEquipoSerial { get; set; } = null!;

    public string? EquEquipoNombreContacto { get; set; }

    public string? EquEquipoTelefonoContacto { get; set; }

    public string? EquEquipoUbicacion { get; set; }

    public string? EquEquipoObservaciones { get; set; }

    public DateTime? EquEquipoFechaPuestaMarchaFh { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaFabricaFf { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaDistribuidorFf { get; set; }

    public double? EquEquipoHorasGarantia { get; set; }

    public DateTime? EquEquipoUltimaLecturaFh { get; set; }

    public double EquEquipoHorometroActual { get; set; }

    public double EquEquipoPromedioHoras { get; set; }

    public decimal? EquEquipoCosto { get; set; }

    public DateTime? EquEquipoFechaImportacionFf { get; set; }

    public string? EquEquipoGarantiaCancelada { get; set; }

    public int EquEquipoIdCatalogoEquipo { get; set; }

    public int EquEquipoIdSistema { get; set; }

    public int EquEquipoIdSucursal { get; set; }

    public int EquEquipoIdZona { get; set; }

    public int EquEquipoIdVersionEquipo { get; set; }

    public int EquEquipoIdTerceroComprador { get; set; }

    public int EquEquipoIdTercero { get; set; }

    public int EquEquipoIdTerceroServicio { get; set; }

    public int EquEquipoIdEquipo { get; set; }

    public int EquEquipoIdEstadoEquipo { get; set; }

    public double? ValorMulta { get; set; }

    public bool Facturado { get; set; }

    public DateTime? FechaInicialFf { get; set; }

    public DateTime? FechaFinFf { get; set; }

    public int? IdDocumento { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
