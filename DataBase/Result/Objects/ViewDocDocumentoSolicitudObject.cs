namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoSolicitudObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoSolicitud { get; set; } = null!;
    public string? Email { get; set; }
    public string? Fax { get; set; }
    public string Telefono { get; set; } = null!;
    public string Solicitante { get; set; } = null!;
    public string? MotivoServicio { get; set; }
    public bool SolucionTelefonica { get; set; }
    public int IdDepartamentoSolicitud { get; set; }
    public string OrtDepartamentoSolicitudDepartamentoSolicitud { get; set; } = null!;
    public string? OrtDepartamentoSolicitudDepartamentoSolicitudCodigo { get; set; }
    public bool OrtDepartamentoSolicitudRecibeSolicitudes { get; set; }
    public int IdMedioSolicitud { get; set; }
    public string DocMedioSolicitudMedioSolicitud { get; set; } = null!;
    public string? DocMedioSolicitudMedioSolicitudCodigo { get; set; }
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
    public int IdZona { get; set; }
    public string GenZonaZona { get; set; } = null!;
    public string? GenZonaZonaCodigo { get; set; }
    public double? GenZonaTiempoDesplazamiento { get; set; }
    public int GenZonaNivel { get; set; }
    public int GenZonaIdZona { get; set; }
    public string? GenZonaCodigoExterno { get; set; }
    public string? Cargo { get; set; }
    public string? Direccion { get; set; }
    public int? DocDocumentoSolicitudDocPrioridadDocumentoOrden { get; set; }
    public string? DocDocumentoSolicitudDocumentoCodigo { get; set; }
    public int DocDocumentoSolicitudDocumentoNumero { get; set; }
    public string DocDocumentoSolicitudPrefijo { get; set; } = null!;
    public double DocDocumentoSolicitudSubtotal { get; set; }
    public double DocDocumentoSolicitudDescuento { get; set; }
    public double DocDocumentoSolicitudIva { get; set; }
    public double DocDocumentoSolicitudTotal { get; set; }
    public double DocDocumentoSolicitudCosto { get; set; }
    public double DocDocumentoSolicitudRentabilidad { get; set; }
    public double DocDocumentoSolicitudTrm { get; set; }
    public DateTime DocDocumentoSolicitudFechaFh { get; set; }
    public DateTime DocDocumentoSolicitudFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoSolicitudFechaCierreFf { get; set; }
    public DateTime DocDocumentoSolicitudFechaLimiteFh { get; set; }
    public int DocDocumentoSolicitudIdSubtipoDocumento { get; set; }
    public string DocDocumentoSolicitudDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;
    public string? DocDocumentoSolicitudDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }
    public string DocDocumentoSolicitudDocSubtipoDocumentoPrefijo { get; set; } = null!;
    public int DocDocumentoSolicitudDocSubtipoDocumentoConsecutivo { get; set; }
    public int DocDocumentoSolicitudDocSubtipoDocumentoIdTipoDocumento { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoProgramarPlaneadas { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoCargarSolicitante { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoVerCentroCosto { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoVerIncoterm { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoValUrgente { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoBloquearDespacho { get; set; }
    public bool DocDocumentoSolicitudDocSubtipoDocumentoCerrarSol { get; set; }
    public int DocDocumentoSolicitudIdTerceroCliente { get; set; }
    public string DocDocumentoSolicitudTerTerceroClienteTercero { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroClienteTerceroCodigo { get; set; }
    public string DocDocumentoSolicitudTerTerceroClienteTerceroNit { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroClienteDireccion { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteContacto { get; set; }
    public string DocDocumentoSolicitudTerTerceroClienteTelefono { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroClienteFax { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteEmail { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteWebsite { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteRepresentante { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteNotas { get; set; }
    public string DocDocumentoSolicitudTerTerceroClienteTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoSolicitudTerTerceroClienteEsCliente { get; set; }
    public bool DocDocumentoSolicitudTerTerceroClienteEsProveedor { get; set; }
    public bool DocDocumentoSolicitudTerTerceroClienteEsTransportador { get; set; }
    public bool DocDocumentoSolicitudTerTerceroClienteEsFabricante { get; set; }
    public bool DocDocumentoSolicitudTerTerceroClienteEsEmpresaPropia { get; set; }
    public string? DocDocumentoSolicitudTerTerceroClienteClasificacion { get; set; }
    public int DocDocumentoSolicitudTerTerceroClienteIdZona { get; set; }
    public int DocDocumentoSolicitudTerTerceroClienteIdEstadoTercero { get; set; }
    public int DocDocumentoSolicitudTerTerceroClienteIdNaturalezaTercero { get; set; }
    public bool DocDocumentoSolicitudTerTerceroClienteEsProspecto { get; set; }
    public int DocDocumentoSolicitudIdDocumento { get; set; }
    public string DocDocumentoSolicitudDocDocumentoPadreDocumento { get; set; } = null!;
    public string? DocDocumentoSolicitudDocDocumentoPadreDocumentoCodigo { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreDocumentoNumero { get; set; }
    public string DocDocumentoSolicitudDocDocumentoPadrePrefijo { get; set; } = null!;
    public double DocDocumentoSolicitudDocDocumentoPadreSubtotal { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreDescuento { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreIva { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreTotal { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreCosto { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreRentabilidad { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreTrm { get; set; }
    public DateTime DocDocumentoSolicitudDocDocumentoPadreFechaFh { get; set; }
    public DateTime DocDocumentoSolicitudDocDocumentoPadreFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoSolicitudDocDocumentoPadreFechaCierreFf { get; set; }
    public DateTime DocDocumentoSolicitudDocDocumentoPadreFechaLimiteFh { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdSubtipoDocumento { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdTerceroCliente { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdDocumento { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdTerceroProveedor { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdPrioridadDocumento { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdMoneda { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdMotivoestado { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreSubtotalPlaneado { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreDescuentoPlaneado { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreIvaPlaneado { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreTotalPlaneado { get; set; }
    public double DocDocumentoSolicitudDocDocumentoPadreCostoPlaneado { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdUsuarioAsignado { get; set; }
    public int DocDocumentoSolicitudDocDocumentoPadreIdUsuarioEnUso { get; set; }
    public int DocDocumentoSolicitudIdTerceroProveedor { get; set; }
    public string DocDocumentoSolicitudTerTerceroProveedorTercero { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroProveedorTerceroCodigo { get; set; }
    public string DocDocumentoSolicitudTerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroProveedorDireccion { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorContacto { get; set; }
    public string DocDocumentoSolicitudTerTerceroProveedorTelefono { get; set; } = null!;
    public string? DocDocumentoSolicitudTerTerceroProveedorFax { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorEmail { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorWebsite { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorRepresentante { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorNotas { get; set; }
    public string DocDocumentoSolicitudTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoSolicitudTerTerceroProveedorEsCliente { get; set; }
    public bool DocDocumentoSolicitudTerTerceroProveedorEsProveedor { get; set; }
    public bool DocDocumentoSolicitudTerTerceroProveedorEsTransportador { get; set; }
    public bool DocDocumentoSolicitudTerTerceroProveedorEsFabricante { get; set; }
    public bool DocDocumentoSolicitudTerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? DocDocumentoSolicitudTerTerceroProveedorClasificacion { get; set; }
    public int DocDocumentoSolicitudTerTerceroProveedorIdZona { get; set; }
    public int DocDocumentoSolicitudTerTerceroProveedorIdEstadoTercero { get; set; }
    public int DocDocumentoSolicitudTerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool DocDocumentoSolicitudTerTerceroProveedorEsProspecto { get; set; }
    public int DocDocumentoSolicitudIdPrioridadDocumento { get; set; }
    public string DocDocumentoSolicitudDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocDocumentoSolicitudDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocDocumentoSolicitudDocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocDocumentoSolicitudDocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocDocumentoSolicitudDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int DocDocumentoSolicitudIdMoneda { get; set; }
    public string DocDocumentoSolicitudGenMonedaMoneda { get; set; } = null!;
    public string? DocDocumentoSolicitudGenMonedaMonedaCodigo { get; set; }
    public string DocDocumentoSolicitudGenMonedaAbreviatura { get; set; } = null!;
    public double DocDocumentoSolicitudGenMonedaCambio { get; set; }
    public int DocDocumentoSolicitudIdEstadoTipoDocumento { get; set; }
    public string DocDocumentoSolicitudDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? DocDocumentoSolicitudDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocDocumentoSolicitudDocEstadoTipoDocumentoAfectaIndicador { get; set; }
    public bool DocDocumentoSolicitudDocEstadoTipoDocumentoEditaDocumento { get; set; }
    public int DocDocumentoSolicitudDocEstadoTipoDocumentoOrden { get; set; }
    public bool DocDocumentoSolicitudDocEstadoTipoDocumentoPuedeRegresar { get; set; }
    public string DocDocumentoSolicitudDocEstadoTipoDocumentoColor { get; set; } = null!;
    public bool DocDocumentoSolicitudDocEstadoTipoDocumentoAfectaInventario { get; set; }
    public int DocDocumentoSolicitudDocEstadoTipoDocumentoIdTipoDocumento { get; set; }
    public string? DocDocumentoSolicitudDocEstadoTipoDocumentoDescripcion { get; set; }
    public int DocDocumentoSolicitudIdMotivoestado { get; set; }
    public string DocDocumentoSolicitudDocMotivoestadoMotivoestado { get; set; } = null!;
    public string? DocDocumentoSolicitudDocMotivoestadoMotivoestadoCodigo { get; set; }
    public int DocDocumentoSolicitudDocMotivoestadoIdEstadoTipoDocumento { get; set; }
    public double DocDocumentoSolicitudSubtotalPlaneado { get; set; }
    public double DocDocumentoSolicitudDescuentoPlaneado { get; set; }
    public double DocDocumentoSolicitudIvaPlaneado { get; set; }
    public double DocDocumentoSolicitudTotalPlaneado { get; set; }
    public double DocDocumentoSolicitudCostoPlaneado { get; set; }
    public int DocDocumentoSolicitudIdUsuarioAsignado { get; set; }
    public string DocDocumentoSolicitudSegUsuarioAsignadoUsuario { get; set; } = null!;
    public string? DocDocumentoSolicitudSegUsuarioAsignadoUsuarioCodigo { get; set; }
    public int? DocDocumentoSolicitudSegUsuarioAsignadoIntentosFallidos { get; set; }
    public int? DocDocumentoSolicitudSegUsuarioAsignadoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioAsignadoClave { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioAsignadoNombre { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioAsignadoProfesion { get; set; }
    public string DocDocumentoSolicitudSegUsuarioAsignadoEmail { get; set; } = null!;
    public string? DocDocumentoSolicitudSegUsuarioAsignadoDireccion { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioAsignadoTelefono { get; set; }
    public decimal? DocDocumentoSolicitudSegUsuarioAsignadoCostoHora { get; set; }
    public double? DocDocumentoSolicitudSegUsuarioAsignadoPorcentajeComision { get; set; }
    public bool? DocDocumentoSolicitudSegUsuarioAsignadoAccesoActivo { get; set; }
    public bool? DocDocumentoSolicitudSegUsuarioAsignadoCambiarClave { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioAsignadoAplicaRecargo { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioAsignadoSexo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioAsignadoIdPerfil { get; set; }
    public int DocDocumentoSolicitudSegUsuarioAsignadoIdCargo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioAsignadoIdGrupo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioAsignadoIdZona { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioAsignadoIdentificacion { get; set; }
    public int DocDocumentoSolicitudSegUsuarioAsignadoIdUsuario { get; set; }
    public byte[]? DocDocumentoSolicitudSegUsuarioAsignadoPreferencias { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioAsignadoHabilitado { get; set; }
    public int DocDocumentoSolicitudIdUsuarioEnUso { get; set; }
    public string DocDocumentoSolicitudSegUsuarioEnUsoUsuario { get; set; } = null!;
    public string? DocDocumentoSolicitudSegUsuarioEnUsoUsuarioCodigo { get; set; }
    public int? DocDocumentoSolicitudSegUsuarioEnUsoIntentosFallidos { get; set; }
    public int? DocDocumentoSolicitudSegUsuarioEnUsoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioEnUsoClave { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioEnUsoNombre { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioEnUsoProfesion { get; set; }
    public string DocDocumentoSolicitudSegUsuarioEnUsoEmail { get; set; } = null!;
    public string? DocDocumentoSolicitudSegUsuarioEnUsoDireccion { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioEnUsoTelefono { get; set; }
    public decimal? DocDocumentoSolicitudSegUsuarioEnUsoCostoHora { get; set; }
    public double? DocDocumentoSolicitudSegUsuarioEnUsoPorcentajeComision { get; set; }
    public bool? DocDocumentoSolicitudSegUsuarioEnUsoAccesoActivo { get; set; }
    public bool? DocDocumentoSolicitudSegUsuarioEnUsoCambiarClave { get; set; }
    public DateTime? DocDocumentoSolicitudSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioEnUsoAplicaRecargo { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioEnUsoSexo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioEnUsoIdPerfil { get; set; }
    public int DocDocumentoSolicitudSegUsuarioEnUsoIdCargo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioEnUsoIdGrupo { get; set; }
    public int DocDocumentoSolicitudSegUsuarioEnUsoIdZona { get; set; }
    public string? DocDocumentoSolicitudSegUsuarioEnUsoIdentificacion { get; set; }
    public int DocDocumentoSolicitudSegUsuarioEnUsoIdUsuario { get; set; }
    public byte[]? DocDocumentoSolicitudSegUsuarioEnUsoPreferencias { get; set; }
    public bool DocDocumentoSolicitudSegUsuarioEnUsoHabilitado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
