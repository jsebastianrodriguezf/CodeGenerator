using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCntVisitaFija
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string VisitaFija { get; set; } = null!;

    public string? VisitaFijaCodigo { get; set; }

    public DateTime FechaFf { get; set; }

    public DateTime FechaCreadaFf { get; set; }

    public double? Horometro { get; set; }

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

    public int DocDocumentoOtIdUsuarioAsignado { get; set; }

    public int DocDocumentoOtIdUsuarioEnUso { get; set; }

    public int IdContratoEquipo { get; set; }

    public string CntContratoEquipoContratoEquipo { get; set; } = null!;

    public string? CntContratoEquipoContratoEquipoCodigo { get; set; }

    public decimal? CntContratoEquipoPrecioVisita { get; set; }

    public decimal? CntContratoEquipoPrecioServicio { get; set; }

    public DateTime? CntContratoEquipoFechaFf { get; set; }

    public double? CntContratoEquipoPromedio { get; set; }

    public int CntContratoEquipoIdEquipo { get; set; }

    public int CntContratoEquipoIdContrato { get; set; }

    public int CntContratoEquipoIdContratoDetalleVisita { get; set; }

    public int IdContratoDetalleVisita { get; set; }

    public string CntContratoDetalleVisitaContratoDetalleVisita { get; set; } = null!;

    public string? CntContratoDetalleVisitaContratoDetalleVisitaCodigo { get; set; }

    public int CntContratoDetalleVisitaFrecuencia { get; set; }

    public double? CntContratoDetalleVisitaCadaN { get; set; }

    public int CntContratoDetalleVisitaDia { get; set; }

    public int CntContratoDetalleVisitaEstrategia { get; set; }

    public bool CntContratoDetalleVisitaPorTrabajo { get; set; }

    public bool CntContratoDetalleVisitaIncluirMenores { get; set; }

    public int CntContratoDetalleVisitaAproximarA { get; set; }

    public DateTime CntContratoDetalleVisitaFechaFf { get; set; }

    public int CntContratoDetalleVisitaIdContrato { get; set; }

    public int CntContratoDetalleVisitaDiaHabil { get; set; }

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

    public bool? EsPorTrabajo { get; set; }

    public string CorreoRecordatorio { get; set; } = null!;

    public double? Presupuesto { get; set; }

    public int? IdConfigContrato { get; set; }

    public string CntConfigContratoConfigContrato { get; set; } = null!;

    public int? CntConfigContratoIdContratoEquipo { get; set; }

    public int? CntConfigContratoIdCatalogoTempario { get; set; }

    public int? CntConfigContratoIdTerceroProveedor { get; set; }

    public int? CntConfigContratoFrecuencia { get; set; }

    public double? CntConfigContratoCadaN { get; set; }

    public int? CntConfigContratoDia { get; set; }

    public int? CntConfigContratoEstrategia { get; set; }

    public bool? CntConfigContratoPorTrabajo { get; set; }

    public bool? CntConfigContratoIncluirMenores { get; set; }

    public int? CntConfigContratoAproximarA { get; set; }

    public DateTime? CntConfigContratoFechaFf { get; set; }

    public int? CntConfigContratoDiaHabil { get; set; }

    public string Multiempresa { get; set; } = null!;

    public DateTime? Fechavencimiento { get; set; }

    public int CntContratoIdTercero { get; set; }

    public string Tipocontrato { get; set; } = null!;

    public int CntTipocontratoId { get; set; }

    public int EquEquipoId { get; set; }

    public string EquEquipoEquipo { get; set; } = null!;

    public string EquEquipoEquipoSerial { get; set; } = null!;

    public string CntContratoContrato { get; set; } = null!;

    public int GenZonaId { get; set; }

    public string TerSucursalSucursal { get; set; } = null!;

    public string? TerSucursalDireccion { get; set; }
}
