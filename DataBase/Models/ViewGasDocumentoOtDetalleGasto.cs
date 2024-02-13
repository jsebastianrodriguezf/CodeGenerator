using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGasDocumentoOtDetalleGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOtDetalleGasto { get; set; } = null!;

    public int IdDetalleGasto { get; set; }

    public string GasDetalleGastoDetalleGasto { get; set; } = null!;

    public string? GasDetalleGastoDetalleGastoCodigo { get; set; }

    public DateTime GasDetalleGastoFechaFf { get; set; }

    public double GasDetalleGastoValor { get; set; }

    public double GasDetalleGastoCantidad { get; set; }

    public int GasDetalleGastoIdGasto { get; set; }

    public int GasDetalleGastoIdCatalogo { get; set; }

    public int IdDocumentoOt { get; set; }

    public string DocDocumentoOtDocumentoOt { get; set; } = null!;

    public string DocDocumentoOtMotivoServicio { get; set; } = null!;

    public bool DocDocumentoOtEnTaller { get; set; }

    public string? DocDocumentoOtDiagnosticoInicial { get; set; }

    public string DocDocumentoOtContacto { get; set; } = null!;

    public string? DocDocumentoOtCargo { get; set; }

    public string DocDocumentoOtTelefono { get; set; } = null!;

    public string? DocDocumentoOtFax { get; set; }

    public string? DocDocumentoOtEmail { get; set; }

    public string? DocDocumentoOtDireccionUbicacion { get; set; }

    public double DocDocumentoOtDuracionEstimada { get; set; }

    public DateTime? DocDocumentoOtFechaGarantiaFf { get; set; }

    public DateTime DocDocumentoOtFechaCompromisoFh { get; set; }

    public string? DocDocumentoOtTrabajos { get; set; }

    public string? DocDocumentoOtRecomendaciones { get; set; }

    public string? DocDocumentoOtCompromisos { get; set; }

    public string? DocDocumentoOtReclamacionFabrica { get; set; }

    public double? DocDocumentoOtPorcentajeCliente { get; set; }

    public double? DocDocumentoOtPorcentajeDistribuidor { get; set; }

    public double? DocDocumentoOtPorcentajeFabricante { get; set; }

    public bool? DocDocumentoOtSegunTempario { get; set; }

    public bool? DocDocumentoOtDistribuyeCentros { get; set; }

    public int DocDocumentoOtIdTipoServicio { get; set; }

    public int DocDocumentoOtIdEquipo { get; set; }

    public int DocDocumentoOtIdUsuarioCoordinador { get; set; }

    public int DocDocumentoOtIdMotivoCancelacion { get; set; }

    public int DocDocumentoOtIdSucursal { get; set; }

    public int DocDocumentoOtIdSistema { get; set; }

    public int DocDocumentoOtIdDepartamentoSolicitud { get; set; }

    public int DocDocumentoOtIdContrato { get; set; }

    public int DocDocumentoOtIdZona { get; set; }

    public string? DocDocumentoOtDocumentoCodigo { get; set; }

    public int DocDocumentoOtDocumentoNumero { get; set; }

    public string DocDocumentoOtPrefijo { get; set; } = null!;

    public double DocDocumentoOtSubtotal { get; set; }

    public double DocDocumentoOtDescuento { get; set; }

    public double DocDocumentoOtIva { get; set; }

    public double DocDocumentoOtTotal { get; set; }

    public double DocDocumentoOtCosto { get; set; }

    public double DocDocumentoOtRentabilidad { get; set; }

    public double DocDocumentoOtTrm { get; set; }

    public DateTime DocDocumentoOtFechaFh { get; set; }

    public DateTime DocDocumentoOtFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOtFechaCierreFf { get; set; }

    public DateTime DocDocumentoOtFechaLimiteFh { get; set; }

    public int DocDocumentoOtIdSubtipoDocumento { get; set; }

    public int DocDocumentoOtIdTerceroCliente { get; set; }

    public int DocDocumentoOtIdDocumento { get; set; }

    public int DocDocumentoOtIdTerceroProveedor { get; set; }

    public int DocDocumentoOtIdPrioridadDocumento { get; set; }

    public int DocDocumentoOtIdMoneda { get; set; }

    public int DocDocumentoOtIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoOtIdMotivoestado { get; set; }

    public double DocDocumentoOtSubtotalPlaneado { get; set; }

    public double DocDocumentoOtDescuentoPlaneado { get; set; }

    public double DocDocumentoOtIvaPlaneado { get; set; }

    public double DocDocumentoOtTotalPlaneado { get; set; }

    public double DocDocumentoOtCostoPlaneado { get; set; }

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
