namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoSalidumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoSalida { get; set; } = null!;
    public string? TelefonoEntrega { get; set; }
    public string? DireccionEntrega { get; set; }
    public string? Asunto { get; set; }
    public string? Observaciones { get; set; }
    public string? Solicitante { get; set; }
    public int IdUsuarioRecibe { get; set; }
    public string SegUsuarioRecibeUsuario { get; set; } = null!;
    public string? SegUsuarioRecibeUsuarioCodigo { get; set; }
    public int? SegUsuarioRecibeIntentosFallidos { get; set; }
    public int? SegUsuarioRecibeNumeroIngresos { get; set; }
    public DateTime? SegUsuarioRecibeFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioRecibeFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioRecibeClave { get; set; }
    public string? SegUsuarioRecibeNombre { get; set; }
    public string? SegUsuarioRecibeProfesion { get; set; }
    public string SegUsuarioRecibeEmail { get; set; } = null!;
    public string? SegUsuarioRecibeDireccion { get; set; }
    public string? SegUsuarioRecibeTelefono { get; set; }
    public decimal? SegUsuarioRecibeCostoHora { get; set; }
    public double? SegUsuarioRecibePorcentajeComision { get; set; }
    public bool? SegUsuarioRecibeAccesoActivo { get; set; }
    public bool? SegUsuarioRecibeCambiarClave { get; set; }
    public DateTime? SegUsuarioRecibeFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioRecibeAplicaRecargo { get; set; }
    public bool SegUsuarioRecibeSexo { get; set; }
    public int SegUsuarioRecibeIdPerfil { get; set; }
    public int SegUsuarioRecibeIdCargo { get; set; }
    public int SegUsuarioRecibeIdGrupo { get; set; }
    public int SegUsuarioRecibeIdZona { get; set; }
    public string? SegUsuarioRecibeIdentificacion { get; set; }
    public int SegUsuarioRecibeIdUsuario { get; set; }
    public byte[]? SegUsuarioRecibePreferencias { get; set; }
    public bool SegUsuarioRecibeHabilitado { get; set; }
    public int IdTerceroTransportador { get; set; }
    public string TerTerceroTransportadorTercero { get; set; } = null!;
    public string? TerTerceroTransportadorTerceroCodigo { get; set; }
    public string TerTerceroTransportadorTerceroNit { get; set; } = null!;
    public string? TerTerceroTransportadorDireccion { get; set; }
    public string? TerTerceroTransportadorContacto { get; set; }
    public string TerTerceroTransportadorTelefono { get; set; } = null!;
    public string? TerTerceroTransportadorFax { get; set; }
    public string? TerTerceroTransportadorEmail { get; set; }
    public string? TerTerceroTransportadorWebsite { get; set; }
    public string? TerTerceroTransportadorRepresentante { get; set; }
    public string? TerTerceroTransportadorNotas { get; set; }
    public string TerTerceroTransportadorTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroTransportadorEsCliente { get; set; }
    public bool TerTerceroTransportadorEsProveedor { get; set; }
    public bool TerTerceroTransportadorEsTransportador { get; set; }
    public bool TerTerceroTransportadorEsFabricante { get; set; }
    public bool TerTerceroTransportadorEsEmpresaPropia { get; set; }
    public string? TerTerceroTransportadorClasificacion { get; set; }
    public int TerTerceroTransportadorIdZona { get; set; }
    public int TerTerceroTransportadorIdEstadoTercero { get; set; }
    public int TerTerceroTransportadorIdNaturalezaTercero { get; set; }
    public bool TerTerceroTransportadorEsProspecto { get; set; }
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
    public int? DocDocumentoSalidaDocPrioridadDocumentoOrden { get; set; }
    public string? DocDocumentoSalidaDocumentoCodigo { get; set; }
    public int DocDocumentoSalidaDocumentoNumero { get; set; }
    public string DocDocumentoSalidaPrefijo { get; set; } = null!;
    public double DocDocumentoSalidaSubtotal { get; set; }
    public double DocDocumentoSalidaDescuento { get; set; }
    public double DocDocumentoSalidaIva { get; set; }
    public double DocDocumentoSalidaTotal { get; set; }
    public double DocDocumentoSalidaCosto { get; set; }
    public double DocDocumentoSalidaRentabilidad { get; set; }
    public double DocDocumentoSalidaTrm { get; set; }
    public DateTime DocDocumentoSalidaFechaFh { get; set; }
    public DateTime DocDocumentoSalidaFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoSalidaFechaCierreFf { get; set; }
    public DateTime DocDocumentoSalidaFechaLimiteFh { get; set; }
    public int DocDocumentoSalidaIdSubtipoDocumento { get; set; }
    public string DocDocumentoSalidaDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;
    public string? DocDocumentoSalidaDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }
    public string DocDocumentoSalidaDocSubtipoDocumentoPrefijo { get; set; } = null!;
    public int DocDocumentoSalidaDocSubtipoDocumentoConsecutivo { get; set; }
    public int DocDocumentoSalidaDocSubtipoDocumentoIdTipoDocumento { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoProgramarPlaneadas { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoCargarSolicitante { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoVerCentroCosto { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoVerIncoterm { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoValUrgente { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoBloquearDespacho { get; set; }
    public bool DocDocumentoSalidaDocSubtipoDocumentoCerrarSol { get; set; }
    public int DocDocumentoSalidaIdTerceroCliente { get; set; }
    public string DocDocumentoSalidaTerTerceroClienteTercero { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroClienteTerceroCodigo { get; set; }
    public string DocDocumentoSalidaTerTerceroClienteTerceroNit { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroClienteDireccion { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteContacto { get; set; }
    public string DocDocumentoSalidaTerTerceroClienteTelefono { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroClienteFax { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteEmail { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteWebsite { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteRepresentante { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteNotas { get; set; }
    public string DocDocumentoSalidaTerTerceroClienteTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoSalidaTerTerceroClienteEsCliente { get; set; }
    public bool DocDocumentoSalidaTerTerceroClienteEsProveedor { get; set; }
    public bool DocDocumentoSalidaTerTerceroClienteEsTransportador { get; set; }
    public bool DocDocumentoSalidaTerTerceroClienteEsFabricante { get; set; }
    public bool DocDocumentoSalidaTerTerceroClienteEsEmpresaPropia { get; set; }
    public string? DocDocumentoSalidaTerTerceroClienteClasificacion { get; set; }
    public int DocDocumentoSalidaTerTerceroClienteIdZona { get; set; }
    public int DocDocumentoSalidaTerTerceroClienteIdEstadoTercero { get; set; }
    public int DocDocumentoSalidaTerTerceroClienteIdNaturalezaTercero { get; set; }
    public bool DocDocumentoSalidaTerTerceroClienteEsProspecto { get; set; }
    public int DocDocumentoSalidaIdDocumento { get; set; }
    public string DocDocumentoSalidaDocDocumentoPadreDocumento { get; set; } = null!;
    public string? DocDocumentoSalidaDocDocumentoPadreDocumentoCodigo { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreDocumentoNumero { get; set; }
    public string DocDocumentoSalidaDocDocumentoPadrePrefijo { get; set; } = null!;
    public double DocDocumentoSalidaDocDocumentoPadreSubtotal { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreDescuento { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreIva { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreTotal { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreCosto { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreRentabilidad { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreTrm { get; set; }
    public DateTime DocDocumentoSalidaDocDocumentoPadreFechaFh { get; set; }
    public DateTime DocDocumentoSalidaDocDocumentoPadreFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoSalidaDocDocumentoPadreFechaCierreFf { get; set; }
    public DateTime DocDocumentoSalidaDocDocumentoPadreFechaLimiteFh { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdSubtipoDocumento { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdTerceroCliente { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdDocumento { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdTerceroProveedor { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdPrioridadDocumento { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdMoneda { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdMotivoestado { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreSubtotalPlaneado { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreDescuentoPlaneado { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreIvaPlaneado { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreTotalPlaneado { get; set; }
    public double DocDocumentoSalidaDocDocumentoPadreCostoPlaneado { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdUsuarioAsignado { get; set; }
    public int DocDocumentoSalidaDocDocumentoPadreIdUsuarioEnUso { get; set; }
    public int DocDocumentoSalidaIdTerceroProveedor { get; set; }
    public string DocDocumentoSalidaTerTerceroProveedorTercero { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroProveedorTerceroCodigo { get; set; }
    public string DocDocumentoSalidaTerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroProveedorDireccion { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorContacto { get; set; }
    public string DocDocumentoSalidaTerTerceroProveedorTelefono { get; set; } = null!;
    public string? DocDocumentoSalidaTerTerceroProveedorFax { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorEmail { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorWebsite { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorRepresentante { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorNotas { get; set; }
    public string DocDocumentoSalidaTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoSalidaTerTerceroProveedorEsCliente { get; set; }
    public bool DocDocumentoSalidaTerTerceroProveedorEsProveedor { get; set; }
    public bool DocDocumentoSalidaTerTerceroProveedorEsTransportador { get; set; }
    public bool DocDocumentoSalidaTerTerceroProveedorEsFabricante { get; set; }
    public bool DocDocumentoSalidaTerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? DocDocumentoSalidaTerTerceroProveedorClasificacion { get; set; }
    public int DocDocumentoSalidaTerTerceroProveedorIdZona { get; set; }
    public int DocDocumentoSalidaTerTerceroProveedorIdEstadoTercero { get; set; }
    public int DocDocumentoSalidaTerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool DocDocumentoSalidaTerTerceroProveedorEsProspecto { get; set; }
    public int DocDocumentoSalidaIdPrioridadDocumento { get; set; }
    public string DocDocumentoSalidaDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocDocumentoSalidaDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocDocumentoSalidaDocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocDocumentoSalidaDocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocDocumentoSalidaDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int DocDocumentoSalidaIdMoneda { get; set; }
    public string DocDocumentoSalidaGenMonedaMoneda { get; set; } = null!;
    public string? DocDocumentoSalidaGenMonedaMonedaCodigo { get; set; }
    public string DocDocumentoSalidaGenMonedaAbreviatura { get; set; } = null!;
    public double DocDocumentoSalidaGenMonedaCambio { get; set; }
    public int DocDocumentoSalidaIdEstadoTipoDocumento { get; set; }
    public string DocDocumentoSalidaDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? DocDocumentoSalidaDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocDocumentoSalidaDocEstadoTipoDocumentoAfectaIndicador { get; set; }
    public bool DocDocumentoSalidaDocEstadoTipoDocumentoEditaDocumento { get; set; }
    public int DocDocumentoSalidaDocEstadoTipoDocumentoOrden { get; set; }
    public bool DocDocumentoSalidaDocEstadoTipoDocumentoPuedeRegresar { get; set; }
    public string DocDocumentoSalidaDocEstadoTipoDocumentoColor { get; set; } = null!;
    public bool DocDocumentoSalidaDocEstadoTipoDocumentoAfectaInventario { get; set; }
    public int DocDocumentoSalidaDocEstadoTipoDocumentoIdTipoDocumento { get; set; }
    public string? DocDocumentoSalidaDocEstadoTipoDocumentoDescripcion { get; set; }
    public int DocDocumentoSalidaIdMotivoestado { get; set; }
    public string DocDocumentoSalidaDocMotivoestadoMotivoestado { get; set; } = null!;
    public string? DocDocumentoSalidaDocMotivoestadoMotivoestadoCodigo { get; set; }
    public int DocDocumentoSalidaDocMotivoestadoIdEstadoTipoDocumento { get; set; }
    public double DocDocumentoSalidaSubtotalPlaneado { get; set; }
    public double DocDocumentoSalidaDescuentoPlaneado { get; set; }
    public double DocDocumentoSalidaIvaPlaneado { get; set; }
    public double DocDocumentoSalidaTotalPlaneado { get; set; }
    public double DocDocumentoSalidaCostoPlaneado { get; set; }
    public int DocDocumentoSalidaIdUsuarioAsignado { get; set; }
    public string DocDocumentoSalidaSegUsuarioAsignadoUsuario { get; set; } = null!;
    public string? DocDocumentoSalidaSegUsuarioAsignadoUsuarioCodigo { get; set; }
    public int? DocDocumentoSalidaSegUsuarioAsignadoIntentosFallidos { get; set; }
    public int? DocDocumentoSalidaSegUsuarioAsignadoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoSalidaSegUsuarioAsignadoClave { get; set; }
    public string? DocDocumentoSalidaSegUsuarioAsignadoNombre { get; set; }
    public string? DocDocumentoSalidaSegUsuarioAsignadoProfesion { get; set; }
    public string DocDocumentoSalidaSegUsuarioAsignadoEmail { get; set; } = null!;
    public string? DocDocumentoSalidaSegUsuarioAsignadoDireccion { get; set; }
    public string? DocDocumentoSalidaSegUsuarioAsignadoTelefono { get; set; }
    public decimal? DocDocumentoSalidaSegUsuarioAsignadoCostoHora { get; set; }
    public double? DocDocumentoSalidaSegUsuarioAsignadoPorcentajeComision { get; set; }
    public bool? DocDocumentoSalidaSegUsuarioAsignadoAccesoActivo { get; set; }
    public bool? DocDocumentoSalidaSegUsuarioAsignadoCambiarClave { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoSalidaSegUsuarioAsignadoAplicaRecargo { get; set; }
    public bool DocDocumentoSalidaSegUsuarioAsignadoSexo { get; set; }
    public int DocDocumentoSalidaSegUsuarioAsignadoIdPerfil { get; set; }
    public int DocDocumentoSalidaSegUsuarioAsignadoIdCargo { get; set; }
    public int DocDocumentoSalidaSegUsuarioAsignadoIdGrupo { get; set; }
    public int DocDocumentoSalidaSegUsuarioAsignadoIdZona { get; set; }
    public string? DocDocumentoSalidaSegUsuarioAsignadoIdentificacion { get; set; }
    public int DocDocumentoSalidaSegUsuarioAsignadoIdUsuario { get; set; }
    public byte[]? DocDocumentoSalidaSegUsuarioAsignadoPreferencias { get; set; }
    public bool DocDocumentoSalidaSegUsuarioAsignadoHabilitado { get; set; }
    public int DocDocumentoSalidaIdUsuarioEnUso { get; set; }
    public string DocDocumentoSalidaSegUsuarioEnUsoUsuario { get; set; } = null!;
    public string? DocDocumentoSalidaSegUsuarioEnUsoUsuarioCodigo { get; set; }
    public int? DocDocumentoSalidaSegUsuarioEnUsoIntentosFallidos { get; set; }
    public int? DocDocumentoSalidaSegUsuarioEnUsoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoSalidaSegUsuarioEnUsoClave { get; set; }
    public string? DocDocumentoSalidaSegUsuarioEnUsoNombre { get; set; }
    public string? DocDocumentoSalidaSegUsuarioEnUsoProfesion { get; set; }
    public string DocDocumentoSalidaSegUsuarioEnUsoEmail { get; set; } = null!;
    public string? DocDocumentoSalidaSegUsuarioEnUsoDireccion { get; set; }
    public string? DocDocumentoSalidaSegUsuarioEnUsoTelefono { get; set; }
    public decimal? DocDocumentoSalidaSegUsuarioEnUsoCostoHora { get; set; }
    public double? DocDocumentoSalidaSegUsuarioEnUsoPorcentajeComision { get; set; }
    public bool? DocDocumentoSalidaSegUsuarioEnUsoAccesoActivo { get; set; }
    public bool? DocDocumentoSalidaSegUsuarioEnUsoCambiarClave { get; set; }
    public DateTime? DocDocumentoSalidaSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoSalidaSegUsuarioEnUsoAplicaRecargo { get; set; }
    public bool DocDocumentoSalidaSegUsuarioEnUsoSexo { get; set; }
    public int DocDocumentoSalidaSegUsuarioEnUsoIdPerfil { get; set; }
    public int DocDocumentoSalidaSegUsuarioEnUsoIdCargo { get; set; }
    public int DocDocumentoSalidaSegUsuarioEnUsoIdGrupo { get; set; }
    public int DocDocumentoSalidaSegUsuarioEnUsoIdZona { get; set; }
    public string? DocDocumentoSalidaSegUsuarioEnUsoIdentificacion { get; set; }
    public int DocDocumentoSalidaSegUsuarioEnUsoIdUsuario { get; set; }
    public byte[]? DocDocumentoSalidaSegUsuarioEnUsoPreferencias { get; set; }
    public bool DocDocumentoSalidaSegUsuarioEnUsoHabilitado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
