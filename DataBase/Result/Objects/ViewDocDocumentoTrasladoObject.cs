namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoTrasladoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoTraslado { get; set; } = null!;
    public int IdBodegaOrigen { get; set; }
    public string GenBodegaOrigenBodega { get; set; } = null!;
    public string? GenBodegaOrigenBodegaCodigo { get; set; }
    public bool GenBodegaOrigenSalidasEnRojo { get; set; }
    public bool GenBodegaOrigenUsaLocalizacion { get; set; }
    public int? GenBodegaOrigenIdSucursal { get; set; }
    public int IdBodegaDestino { get; set; }
    public string GenBodegaDestinoBodega { get; set; } = null!;
    public string? GenBodegaDestinoBodegaCodigo { get; set; }
    public bool GenBodegaDestinoSalidasEnRojo { get; set; }
    public bool GenBodegaDestinoUsaLocalizacion { get; set; }
    public int? GenBodegaDestinoIdSucursal { get; set; }
    public int? DocDocumentoTrasladoDocPrioridadDocumentoOrden { get; set; }
    public string? DocDocumentoTrasladoDocumentoCodigo { get; set; }
    public int DocDocumentoTrasladoDocumentoNumero { get; set; }
    public string DocDocumentoTrasladoPrefijo { get; set; } = null!;
    public double DocDocumentoTrasladoSubtotal { get; set; }
    public double DocDocumentoTrasladoDescuento { get; set; }
    public double DocDocumentoTrasladoIva { get; set; }
    public double DocDocumentoTrasladoTotal { get; set; }
    public double DocDocumentoTrasladoCosto { get; set; }
    public double DocDocumentoTrasladoRentabilidad { get; set; }
    public double DocDocumentoTrasladoTrm { get; set; }
    public DateTime DocDocumentoTrasladoFechaFh { get; set; }
    public DateTime DocDocumentoTrasladoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoTrasladoFechaCierreFf { get; set; }
    public DateTime DocDocumentoTrasladoFechaLimiteFh { get; set; }
    public int DocDocumentoTrasladoIdSubtipoDocumento { get; set; }
    public string DocDocumentoTrasladoDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;
    public string? DocDocumentoTrasladoDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }
    public string DocDocumentoTrasladoDocSubtipoDocumentoPrefijo { get; set; } = null!;
    public int DocDocumentoTrasladoDocSubtipoDocumentoConsecutivo { get; set; }
    public int DocDocumentoTrasladoDocSubtipoDocumentoIdTipoDocumento { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoProgramarPlaneadas { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoCargarSolicitante { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoVerCentroCosto { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoVerIncoterm { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoValUrgente { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoBloquearDespacho { get; set; }
    public bool DocDocumentoTrasladoDocSubtipoDocumentoCerrarSol { get; set; }
    public int DocDocumentoTrasladoIdTerceroCliente { get; set; }
    public string DocDocumentoTrasladoTerTerceroClienteTercero { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroClienteTerceroCodigo { get; set; }
    public string DocDocumentoTrasladoTerTerceroClienteTerceroNit { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroClienteDireccion { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteContacto { get; set; }
    public string DocDocumentoTrasladoTerTerceroClienteTelefono { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroClienteFax { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteEmail { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteWebsite { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteRepresentante { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteNotas { get; set; }
    public string DocDocumentoTrasladoTerTerceroClienteTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoTrasladoTerTerceroClienteEsCliente { get; set; }
    public bool DocDocumentoTrasladoTerTerceroClienteEsProveedor { get; set; }
    public bool DocDocumentoTrasladoTerTerceroClienteEsTransportador { get; set; }
    public bool DocDocumentoTrasladoTerTerceroClienteEsFabricante { get; set; }
    public bool DocDocumentoTrasladoTerTerceroClienteEsEmpresaPropia { get; set; }
    public string? DocDocumentoTrasladoTerTerceroClienteClasificacion { get; set; }
    public int DocDocumentoTrasladoTerTerceroClienteIdZona { get; set; }
    public int DocDocumentoTrasladoTerTerceroClienteIdEstadoTercero { get; set; }
    public int DocDocumentoTrasladoTerTerceroClienteIdNaturalezaTercero { get; set; }
    public bool DocDocumentoTrasladoTerTerceroClienteEsProspecto { get; set; }
    public int DocDocumentoTrasladoIdDocumento { get; set; }
    public string DocDocumentoTrasladoDocDocumentoPadreDocumento { get; set; } = null!;
    public string? DocDocumentoTrasladoDocDocumentoPadreDocumentoCodigo { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreDocumentoNumero { get; set; }
    public string DocDocumentoTrasladoDocDocumentoPadrePrefijo { get; set; } = null!;
    public double DocDocumentoTrasladoDocDocumentoPadreSubtotal { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreDescuento { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreIva { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreTotal { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreCosto { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreRentabilidad { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreTrm { get; set; }
    public DateTime DocDocumentoTrasladoDocDocumentoPadreFechaFh { get; set; }
    public DateTime DocDocumentoTrasladoDocDocumentoPadreFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoTrasladoDocDocumentoPadreFechaCierreFf { get; set; }
    public DateTime DocDocumentoTrasladoDocDocumentoPadreFechaLimiteFh { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdSubtipoDocumento { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdTerceroCliente { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdDocumento { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdTerceroProveedor { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdPrioridadDocumento { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdMoneda { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdMotivoestado { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreSubtotalPlaneado { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreDescuentoPlaneado { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreIvaPlaneado { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreTotalPlaneado { get; set; }
    public double DocDocumentoTrasladoDocDocumentoPadreCostoPlaneado { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdUsuarioAsignado { get; set; }
    public int DocDocumentoTrasladoDocDocumentoPadreIdUsuarioEnUso { get; set; }
    public int DocDocumentoTrasladoIdTerceroProveedor { get; set; }
    public string DocDocumentoTrasladoTerTerceroProveedorTercero { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroProveedorTerceroCodigo { get; set; }
    public string DocDocumentoTrasladoTerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroProveedorDireccion { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorContacto { get; set; }
    public string DocDocumentoTrasladoTerTerceroProveedorTelefono { get; set; } = null!;
    public string? DocDocumentoTrasladoTerTerceroProveedorFax { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorEmail { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorWebsite { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorRepresentante { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorNotas { get; set; }
    public string DocDocumentoTrasladoTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoTrasladoTerTerceroProveedorEsCliente { get; set; }
    public bool DocDocumentoTrasladoTerTerceroProveedorEsProveedor { get; set; }
    public bool DocDocumentoTrasladoTerTerceroProveedorEsTransportador { get; set; }
    public bool DocDocumentoTrasladoTerTerceroProveedorEsFabricante { get; set; }
    public bool DocDocumentoTrasladoTerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? DocDocumentoTrasladoTerTerceroProveedorClasificacion { get; set; }
    public int DocDocumentoTrasladoTerTerceroProveedorIdZona { get; set; }
    public int DocDocumentoTrasladoTerTerceroProveedorIdEstadoTercero { get; set; }
    public int DocDocumentoTrasladoTerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool DocDocumentoTrasladoTerTerceroProveedorEsProspecto { get; set; }
    public int DocDocumentoTrasladoIdPrioridadDocumento { get; set; }
    public string DocDocumentoTrasladoDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocDocumentoTrasladoDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocDocumentoTrasladoDocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocDocumentoTrasladoDocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocDocumentoTrasladoDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int DocDocumentoTrasladoIdMoneda { get; set; }
    public string DocDocumentoTrasladoGenMonedaMoneda { get; set; } = null!;
    public string? DocDocumentoTrasladoGenMonedaMonedaCodigo { get; set; }
    public string DocDocumentoTrasladoGenMonedaAbreviatura { get; set; } = null!;
    public double DocDocumentoTrasladoGenMonedaCambio { get; set; }
    public int DocDocumentoTrasladoIdEstadoTipoDocumento { get; set; }
    public string DocDocumentoTrasladoDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? DocDocumentoTrasladoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocDocumentoTrasladoDocEstadoTipoDocumentoAfectaIndicador { get; set; }
    public bool DocDocumentoTrasladoDocEstadoTipoDocumentoEditaDocumento { get; set; }
    public int DocDocumentoTrasladoDocEstadoTipoDocumentoOrden { get; set; }
    public bool DocDocumentoTrasladoDocEstadoTipoDocumentoPuedeRegresar { get; set; }
    public string DocDocumentoTrasladoDocEstadoTipoDocumentoColor { get; set; } = null!;
    public bool DocDocumentoTrasladoDocEstadoTipoDocumentoAfectaInventario { get; set; }
    public int DocDocumentoTrasladoDocEstadoTipoDocumentoIdTipoDocumento { get; set; }
    public string? DocDocumentoTrasladoDocEstadoTipoDocumentoDescripcion { get; set; }
    public int DocDocumentoTrasladoIdMotivoestado { get; set; }
    public string DocDocumentoTrasladoDocMotivoestadoMotivoestado { get; set; } = null!;
    public string? DocDocumentoTrasladoDocMotivoestadoMotivoestadoCodigo { get; set; }
    public int DocDocumentoTrasladoDocMotivoestadoIdEstadoTipoDocumento { get; set; }
    public double DocDocumentoTrasladoSubtotalPlaneado { get; set; }
    public double DocDocumentoTrasladoDescuentoPlaneado { get; set; }
    public double DocDocumentoTrasladoIvaPlaneado { get; set; }
    public double DocDocumentoTrasladoTotalPlaneado { get; set; }
    public double DocDocumentoTrasladoCostoPlaneado { get; set; }
    public int DocDocumentoTrasladoIdUsuarioAsignado { get; set; }
    public string DocDocumentoTrasladoSegUsuarioAsignadoUsuario { get; set; } = null!;
    public string? DocDocumentoTrasladoSegUsuarioAsignadoUsuarioCodigo { get; set; }
    public int? DocDocumentoTrasladoSegUsuarioAsignadoIntentosFallidos { get; set; }
    public int? DocDocumentoTrasladoSegUsuarioAsignadoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioAsignadoClave { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioAsignadoNombre { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioAsignadoProfesion { get; set; }
    public string DocDocumentoTrasladoSegUsuarioAsignadoEmail { get; set; } = null!;
    public string? DocDocumentoTrasladoSegUsuarioAsignadoDireccion { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioAsignadoTelefono { get; set; }
    public decimal? DocDocumentoTrasladoSegUsuarioAsignadoCostoHora { get; set; }
    public double? DocDocumentoTrasladoSegUsuarioAsignadoPorcentajeComision { get; set; }
    public bool? DocDocumentoTrasladoSegUsuarioAsignadoAccesoActivo { get; set; }
    public bool? DocDocumentoTrasladoSegUsuarioAsignadoCambiarClave { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioAsignadoAplicaRecargo { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioAsignadoSexo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioAsignadoIdPerfil { get; set; }
    public int DocDocumentoTrasladoSegUsuarioAsignadoIdCargo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioAsignadoIdGrupo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioAsignadoIdZona { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioAsignadoIdentificacion { get; set; }
    public int DocDocumentoTrasladoSegUsuarioAsignadoIdUsuario { get; set; }
    public byte[]? DocDocumentoTrasladoSegUsuarioAsignadoPreferencias { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioAsignadoHabilitado { get; set; }
    public int DocDocumentoTrasladoIdUsuarioEnUso { get; set; }
    public string DocDocumentoTrasladoSegUsuarioEnUsoUsuario { get; set; } = null!;
    public string? DocDocumentoTrasladoSegUsuarioEnUsoUsuarioCodigo { get; set; }
    public int? DocDocumentoTrasladoSegUsuarioEnUsoIntentosFallidos { get; set; }
    public int? DocDocumentoTrasladoSegUsuarioEnUsoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioEnUsoClave { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioEnUsoNombre { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioEnUsoProfesion { get; set; }
    public string DocDocumentoTrasladoSegUsuarioEnUsoEmail { get; set; } = null!;
    public string? DocDocumentoTrasladoSegUsuarioEnUsoDireccion { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioEnUsoTelefono { get; set; }
    public decimal? DocDocumentoTrasladoSegUsuarioEnUsoCostoHora { get; set; }
    public double? DocDocumentoTrasladoSegUsuarioEnUsoPorcentajeComision { get; set; }
    public bool? DocDocumentoTrasladoSegUsuarioEnUsoAccesoActivo { get; set; }
    public bool? DocDocumentoTrasladoSegUsuarioEnUsoCambiarClave { get; set; }
    public DateTime? DocDocumentoTrasladoSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioEnUsoAplicaRecargo { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioEnUsoSexo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioEnUsoIdPerfil { get; set; }
    public int DocDocumentoTrasladoSegUsuarioEnUsoIdCargo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioEnUsoIdGrupo { get; set; }
    public int DocDocumentoTrasladoSegUsuarioEnUsoIdZona { get; set; }
    public string? DocDocumentoTrasladoSegUsuarioEnUsoIdentificacion { get; set; }
    public int DocDocumentoTrasladoSegUsuarioEnUsoIdUsuario { get; set; }
    public byte[]? DocDocumentoTrasladoSegUsuarioEnUsoPreferencias { get; set; }
    public bool DocDocumentoTrasladoSegUsuarioEnUsoHabilitado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
