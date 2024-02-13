namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquTrazabilidadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Trazabilidad { get; set; } = null!;
    public string? TrazabilidadCodigo { get; set; }
    public double? Horometro { get; set; }
    public DateTime FechaFf { get; set; }
    public bool EsSoporte { get; set; }
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
    public int IdEquipoPadre { get; set; }
    public string EquEquipoPadreEquipo { get; set; } = null!;
    public string? EquEquipoPadreEquipoCodigo { get; set; }
    public string EquEquipoPadreEquipoSerial { get; set; } = null!;
    public string? EquEquipoPadreNombreContacto { get; set; }
    public string? EquEquipoPadreTelefonoContacto { get; set; }
    public string? EquEquipoPadreUbicacion { get; set; }
    public string? EquEquipoPadreObservaciones { get; set; }
    public DateTime? EquEquipoPadreFechaPuestaMarchaFh { get; set; }
    public DateTime? EquEquipoPadreVencimientoGarantiaFabricaFf { get; set; }
    public DateTime? EquEquipoPadreVencimientoGarantiaDistribuidorFf { get; set; }
    public double? EquEquipoPadreHorasGarantia { get; set; }
    public DateTime? EquEquipoPadreUltimaLecturaFh { get; set; }
    public double EquEquipoPadreHorometroActual { get; set; }
    public double EquEquipoPadrePromedioHoras { get; set; }
    public decimal? EquEquipoPadreCosto { get; set; }
    public DateTime? EquEquipoPadreFechaImportacionFf { get; set; }
    public string? EquEquipoPadreGarantiaCancelada { get; set; }
    public int EquEquipoPadreIdCatalogoEquipo { get; set; }
    public int EquEquipoPadreIdSistema { get; set; }
    public int EquEquipoPadreIdSucursal { get; set; }
    public int EquEquipoPadreIdZona { get; set; }
    public int EquEquipoPadreIdVersionEquipo { get; set; }
    public int EquEquipoPadreIdTerceroComprador { get; set; }
    public int EquEquipoPadreIdTercero { get; set; }
    public int EquEquipoPadreIdTerceroServicio { get; set; }
    public int EquEquipoPadreIdEquipo { get; set; }
    public int EquEquipoPadreIdEstadoEquipo { get; set; }
    public int IdTercero { get; set; }
    public string TerTerceroTercero { get; set; } = null!;
    public string? TerTerceroTerceroCodigo { get; set; }
    public string TerTerceroTerceroNit { get; set; } = null!;
    public string? TerTerceroDireccion { get; set; }
    public string? TerTerceroContacto { get; set; }
    public string TerTerceroTelefono { get; set; } = null!;
    public string? TerTerceroFax { get; set; }
    public string? TerTerceroEmail { get; set; }
    public string? TerTerceroWebsite { get; set; }
    public string? TerTerceroRepresentante { get; set; }
    public string? TerTerceroNotas { get; set; }
    public string TerTerceroTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroEsCliente { get; set; }
    public bool TerTerceroEsProveedor { get; set; }
    public bool TerTerceroEsTransportador { get; set; }
    public bool TerTerceroEsFabricante { get; set; }
    public bool TerTerceroEsEmpresaPropia { get; set; }
    public string? TerTerceroClasificacion { get; set; }
    public int TerTerceroIdZona { get; set; }
    public int TerTerceroIdEstadoTercero { get; set; }
    public int TerTerceroIdNaturalezaTercero { get; set; }
    public bool TerTerceroEsProspecto { get; set; }
    public int IdSucursal { get; set; }
    public string TerSucursalSucursal { get; set; } = null!;
    public string? TerSucursalSucursalCodigo { get; set; }
    public string? TerSucursalContacto { get; set; }
    public string TerSucursalTelefono { get; set; } = null!;
    public string? TerSucursalFax { get; set; }
    public string? TerSucursalEmail { get; set; }
    public string? TerSucursalDireccion { get; set; }
    public bool TerSucursalParaVenta { get; set; }
    public bool TerSucursalParaSoporte { get; set; }
    public bool TerSucursalParaAlquiler { get; set; }
    public int TerSucursalIdTercero { get; set; }
    public int TerSucursalIdZona { get; set; }
    public int TerSucursalIdUsuarioAsesor { get; set; }
    public int TerSucursalIdUsuarioTecnico { get; set; }
    public int TerSucursalIdSucursal { get; set; }
    public int TerSucursalIdEstadoTercero { get; set; }
    public string? TerSucursalCodigorecursiva { get; set; }
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
    public int IdPrestamo { get; set; }
    public string EquPrestamoPrestamo { get; set; } = null!;
    public string? EquPrestamoPrestamoCodigo { get; set; }
    public DateTime? EquPrestamoFechaPrestamoFf { get; set; }
    public DateTime? EquPrestamoFechaCompromisoFf { get; set; }
    public string? EquPrestamoNotas { get; set; }
    public int EquPrestamoIdEstadoPrestamo { get; set; }
    public int EquPrestamoIdUsuarioEntrego { get; set; }
    public int IdReporteTecnico { get; set; }
    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;
    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }
    public string? OrtReporteTecnicoNumero { get; set; }
    public string? OrtReporteTecnicoTrabajos { get; set; }
    public string? OrtReporteTecnicoRecomendaciones { get; set; }
    public string? OrtReporteTecnicoCompromisos { get; set; }
    public int OrtReporteTecnicoIdGasto { get; set; }
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
    public int IdTipoTrazabilidad { get; set; }
    public string EquTipoTrazabilidadTipoTrazabilidad { get; set; } = null!;
    public string? EquTipoTrazabilidadTipoTrazabilidadCodigo { get; set; }
    public int IdCicloHorometro { get; set; }
    public string EquCicloHorometroCicloHorometro { get; set; } = null!;
    public string? EquCicloHorometroCicloHorometroCodigo { get; set; }
    public int EquCicloHorometroIdEquipo { get; set; }
    public double EquCicloHorometroHorometroInicial { get; set; }
    public double EquCicloHorometroHorometroFinal { get; set; }
    public bool EquCicloHorometroAfectarProyeccion { get; set; }
    public bool EquCicloHorometroReparacionMayor { get; set; }
    public bool EquCicloHorometroReiniciarHorometro { get; set; }
    public int EquCicloHorometroNciclo { get; set; }
    public int IdPosicion { get; set; }
    public string CatPosicionPosicion { get; set; } = null!;
    public string? CatPosicionPosicionCodigo { get; set; }
    public int CatPosicionIdCatalogoEquipoEquipo { get; set; }
    public int CatPosicionIdCatalogoEquipoComponente { get; set; }
    public int CatPosicionIdDimensionX { get; set; }
    public int CatPosicionIdDimensionY { get; set; }
    public int CatPosicionIdDimensionZ { get; set; }
    public int IdEstadoEquipo { get; set; }
    public string EquEstadoEquipoEstadoEquipo { get; set; } = null!;
    public string? EquEstadoEquipoEstadoEquipoCodigo { get; set; }
    public bool EquEstadoEquipoActivo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
