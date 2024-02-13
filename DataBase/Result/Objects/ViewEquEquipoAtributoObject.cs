namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquEquipoAtributoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string? EquipoAtributo { get; set; }
    public string? EquipoAtributoCodigo { get; set; }
    public DateTime FechaFf { get; set; }
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
    public int EquEquipoIdCentroCosto { get; set; }
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
    public int IdAtributo { get; set; }
    public string CatAtributoAtributo { get; set; } = null!;
    public string? CatAtributoAtributoCodigo { get; set; }
    public string CatAtributoNombreControl { get; set; } = null!;
    public bool CatAtributoEsVariable { get; set; }
    public bool CatAtributoResaltado { get; set; }
    public double? CatAtributoValorMinimo { get; set; }
    public double? CatAtributoValorMaximo { get; set; }
    public int CatAtributoIdSeccionAtributo { get; set; }
    public int CatAtributoIdTipoAtributo { get; set; }
    public int CatAtributoIdUnidad { get; set; }
    public bool CatAtributoEsObligatorio { get; set; }
    public int IdOpcionAtributo { get; set; }
    public string EquOpcionAtributoOpcionAtributo { get; set; } = null!;
    public string? EquOpcionAtributoOpcionAtributoCodigo { get; set; }
    public int EquOpcionAtributoOrden { get; set; }
    public int EquOpcionAtributoIdAtributo { get; set; }
    public int IdReporteTecnico { get; set; }
    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;
    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }
    public string? OrtReporteTecnicoNumero { get; set; }
    public string? OrtReporteTecnicoTrabajos { get; set; }
    public string? OrtReporteTecnicoRecomendaciones { get; set; }
    public string? OrtReporteTecnicoCompromisos { get; set; }
    public int OrtReporteTecnicoIdGasto { get; set; }
    public int? OrtReporteTecnicoIdCanalAtencion { get; set; }
    public string OrtReporteTecnicoDiagnostico { get; set; } = null!;
    public int? OrtReporteTecnicoIdDocumentoGasto { get; set; }
    public int IdPruebaCheckList { get; set; }
    public string CatPruebaCheckListPruebaCheckList { get; set; } = null!;
    public string? CatPruebaCheckListPruebaCheckListCodigo { get; set; }
    public bool CatPruebaCheckListActivo { get; set; }
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
    public string Unidad { get; set; } = null!;
    public string? DisEventoCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
