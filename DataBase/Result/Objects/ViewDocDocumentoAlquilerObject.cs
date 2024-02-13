namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoAlquiler { get; set; } = null!;
    public DateTime? FechaFinFf { get; set; }
    public bool MesVencido { get; set; }
    public string? Observaciones { get; set; }
    public bool EjecutaDevolucion { get; set; }
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
    public int? DocDocumentoAlquilerDocPrioridadDocumentoOrden { get; set; }
    public int DocDocumentoAlquilerIdSubtipoDocumento { get; set; }
    public string DocDocumentoAlquilerDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;
    public string? DocDocumentoAlquilerDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }
    public string DocDocumentoAlquilerDocSubtipoDocumentoPrefijo { get; set; } = null!;
    public int DocDocumentoAlquilerDocSubtipoDocumentoConsecutivo { get; set; }
    public int DocDocumentoAlquilerDocSubtipoDocumentoIdTipoDocumento { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoProgramarPlaneadas { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoCargarSolicitante { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoVerCentroCosto { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoVerIncoterm { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoValUrgente { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoBloquearDespacho { get; set; }
    public bool DocDocumentoAlquilerDocSubtipoDocumentoCerrarSol { get; set; }
    public int DocDocumentoAlquilerIdTerceroCliente { get; set; }
    public string DocDocumentoAlquilerTerTerceroClienteTercero { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroClienteTerceroCodigo { get; set; }
    public string DocDocumentoAlquilerTerTerceroClienteTerceroNit { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroClienteDireccion { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteContacto { get; set; }
    public string DocDocumentoAlquilerTerTerceroClienteTelefono { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroClienteFax { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteEmail { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteWebsite { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteRepresentante { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteNotas { get; set; }
    public string DocDocumentoAlquilerTerTerceroClienteTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoAlquilerTerTerceroClienteEsCliente { get; set; }
    public bool DocDocumentoAlquilerTerTerceroClienteEsProveedor { get; set; }
    public bool DocDocumentoAlquilerTerTerceroClienteEsTransportador { get; set; }
    public bool DocDocumentoAlquilerTerTerceroClienteEsFabricante { get; set; }
    public bool DocDocumentoAlquilerTerTerceroClienteEsEmpresaPropia { get; set; }
    public string? DocDocumentoAlquilerTerTerceroClienteClasificacion { get; set; }
    public int DocDocumentoAlquilerTerTerceroClienteIdZona { get; set; }
    public int DocDocumentoAlquilerTerTerceroClienteIdEstadoTercero { get; set; }
    public int DocDocumentoAlquilerTerTerceroClienteIdNaturalezaTercero { get; set; }
    public bool DocDocumentoAlquilerTerTerceroClienteEsProspecto { get; set; }
    public int DocDocumentoAlquilerIdDocumento { get; set; }
    public string DocDocumentoAlquilerDocDocumentoPadreDocumento { get; set; } = null!;
    public string? DocDocumentoAlquilerDocDocumentoPadreDocumentoCodigo { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreDocumentoNumero { get; set; }
    public string DocDocumentoAlquilerDocDocumentoPadrePrefijo { get; set; } = null!;
    public double DocDocumentoAlquilerDocDocumentoPadreSubtotal { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreDescuento { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreIva { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreTotal { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreCosto { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreRentabilidad { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreTrm { get; set; }
    public DateTime DocDocumentoAlquilerDocDocumentoPadreFechaFh { get; set; }
    public DateTime DocDocumentoAlquilerDocDocumentoPadreFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoAlquilerDocDocumentoPadreFechaCierreFf { get; set; }
    public DateTime DocDocumentoAlquilerDocDocumentoPadreFechaLimiteFh { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdSubtipoDocumento { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdTerceroCliente { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdDocumento { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdTerceroProveedor { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdPrioridadDocumento { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdMoneda { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdMotivoestado { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreSubtotalPlaneado { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreDescuentoPlaneado { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreIvaPlaneado { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreTotalPlaneado { get; set; }
    public double DocDocumentoAlquilerDocDocumentoPadreCostoPlaneado { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdUsuarioAsignado { get; set; }
    public int DocDocumentoAlquilerDocDocumentoPadreIdUsuarioEnUso { get; set; }
    public int DocDocumentoAlquilerIdTerceroProveedor { get; set; }
    public string DocDocumentoAlquilerTerTerceroProveedorTercero { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroProveedorTerceroCodigo { get; set; }
    public string DocDocumentoAlquilerTerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroProveedorDireccion { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorContacto { get; set; }
    public string DocDocumentoAlquilerTerTerceroProveedorTelefono { get; set; } = null!;
    public string? DocDocumentoAlquilerTerTerceroProveedorFax { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorEmail { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorWebsite { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorRepresentante { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorNotas { get; set; }
    public string DocDocumentoAlquilerTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoAlquilerTerTerceroProveedorEsCliente { get; set; }
    public bool DocDocumentoAlquilerTerTerceroProveedorEsProveedor { get; set; }
    public bool DocDocumentoAlquilerTerTerceroProveedorEsTransportador { get; set; }
    public bool DocDocumentoAlquilerTerTerceroProveedorEsFabricante { get; set; }
    public bool DocDocumentoAlquilerTerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? DocDocumentoAlquilerTerTerceroProveedorClasificacion { get; set; }
    public int DocDocumentoAlquilerTerTerceroProveedorIdZona { get; set; }
    public int DocDocumentoAlquilerTerTerceroProveedorIdEstadoTercero { get; set; }
    public int DocDocumentoAlquilerTerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool DocDocumentoAlquilerTerTerceroProveedorEsProspecto { get; set; }
    public int DocDocumentoAlquilerIdPrioridadDocumento { get; set; }
    public string DocDocumentoAlquilerDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocDocumentoAlquilerDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocDocumentoAlquilerDocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocDocumentoAlquilerDocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocDocumentoAlquilerDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int DocDocumentoAlquilerIdMoneda { get; set; }
    public string DocDocumentoAlquilerGenMonedaMoneda { get; set; } = null!;
    public string? DocDocumentoAlquilerGenMonedaMonedaCodigo { get; set; }
    public string DocDocumentoAlquilerGenMonedaAbreviatura { get; set; } = null!;
    public double DocDocumentoAlquilerGenMonedaCambio { get; set; }
    public int DocDocumentoAlquilerIdEstadoTipoDocumento { get; set; }
    public string DocDocumentoAlquilerDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? DocDocumentoAlquilerDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocDocumentoAlquilerDocEstadoTipoDocumentoAfectaIndicador { get; set; }
    public bool DocDocumentoAlquilerDocEstadoTipoDocumentoEditaDocumento { get; set; }
    public int DocDocumentoAlquilerDocEstadoTipoDocumentoOrden { get; set; }
    public bool DocDocumentoAlquilerDocEstadoTipoDocumentoPuedeRegresar { get; set; }
    public string DocDocumentoAlquilerDocEstadoTipoDocumentoColor { get; set; } = null!;
    public bool DocDocumentoAlquilerDocEstadoTipoDocumentoAfectaInventario { get; set; }
    public int DocDocumentoAlquilerDocEstadoTipoDocumentoIdTipoDocumento { get; set; }
    public string? DocDocumentoAlquilerDocEstadoTipoDocumentoDescripcion { get; set; }
    public int DocDocumentoAlquilerIdMotivoestado { get; set; }
    public string DocDocumentoAlquilerDocMotivoestadoMotivoestado { get; set; } = null!;
    public string? DocDocumentoAlquilerDocMotivoestadoMotivoestadoCodigo { get; set; }
    public int DocDocumentoAlquilerDocMotivoestadoIdEstadoTipoDocumento { get; set; }
    public double DocDocumentoAlquilerSubtotalPlaneado { get; set; }
    public double DocDocumentoAlquilerDescuentoPlaneado { get; set; }
    public double DocDocumentoAlquilerIvaPlaneado { get; set; }
    public double DocDocumentoAlquilerTotalPlaneado { get; set; }
    public double DocDocumentoAlquilerCostoPlaneado { get; set; }
    public int DocDocumentoAlquilerIdUsuarioAsignado { get; set; }
    public string DocDocumentoAlquilerSegUsuarioAsignadoUsuario { get; set; } = null!;
    public string? DocDocumentoAlquilerSegUsuarioAsignadoUsuarioCodigo { get; set; }
    public int? DocDocumentoAlquilerSegUsuarioAsignadoIntentosFallidos { get; set; }
    public int? DocDocumentoAlquilerSegUsuarioAsignadoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioAsignadoClave { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioAsignadoNombre { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioAsignadoProfesion { get; set; }
    public string DocDocumentoAlquilerSegUsuarioAsignadoEmail { get; set; } = null!;
    public string? DocDocumentoAlquilerSegUsuarioAsignadoDireccion { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioAsignadoTelefono { get; set; }
    public decimal? DocDocumentoAlquilerSegUsuarioAsignadoCostoHora { get; set; }
    public double? DocDocumentoAlquilerSegUsuarioAsignadoPorcentajeComision { get; set; }
    public bool? DocDocumentoAlquilerSegUsuarioAsignadoAccesoActivo { get; set; }
    public bool? DocDocumentoAlquilerSegUsuarioAsignadoCambiarClave { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioAsignadoAplicaRecargo { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioAsignadoSexo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioAsignadoIdPerfil { get; set; }
    public int DocDocumentoAlquilerSegUsuarioAsignadoIdCargo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioAsignadoIdGrupo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioAsignadoIdZona { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioAsignadoIdentificacion { get; set; }
    public int DocDocumentoAlquilerSegUsuarioAsignadoIdUsuario { get; set; }
    public byte[]? DocDocumentoAlquilerSegUsuarioAsignadoPreferencias { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioAsignadoHabilitado { get; set; }
    public int DocDocumentoAlquilerIdUsuarioEnUso { get; set; }
    public string DocDocumentoAlquilerSegUsuarioEnUsoUsuario { get; set; } = null!;
    public string? DocDocumentoAlquilerSegUsuarioEnUsoUsuarioCodigo { get; set; }
    public int? DocDocumentoAlquilerSegUsuarioEnUsoIntentosFallidos { get; set; }
    public int? DocDocumentoAlquilerSegUsuarioEnUsoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioEnUsoClave { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioEnUsoNombre { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioEnUsoProfesion { get; set; }
    public string DocDocumentoAlquilerSegUsuarioEnUsoEmail { get; set; } = null!;
    public string? DocDocumentoAlquilerSegUsuarioEnUsoDireccion { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioEnUsoTelefono { get; set; }
    public decimal? DocDocumentoAlquilerSegUsuarioEnUsoCostoHora { get; set; }
    public double? DocDocumentoAlquilerSegUsuarioEnUsoPorcentajeComision { get; set; }
    public bool? DocDocumentoAlquilerSegUsuarioEnUsoAccesoActivo { get; set; }
    public bool? DocDocumentoAlquilerSegUsuarioEnUsoCambiarClave { get; set; }
    public DateTime? DocDocumentoAlquilerSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioEnUsoAplicaRecargo { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioEnUsoSexo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioEnUsoIdPerfil { get; set; }
    public int DocDocumentoAlquilerSegUsuarioEnUsoIdCargo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioEnUsoIdGrupo { get; set; }
    public int DocDocumentoAlquilerSegUsuarioEnUsoIdZona { get; set; }
    public string? DocDocumentoAlquilerSegUsuarioEnUsoIdentificacion { get; set; }
    public int DocDocumentoAlquilerSegUsuarioEnUsoIdUsuario { get; set; }
    public byte[]? DocDocumentoAlquilerSegUsuarioEnUsoPreferencias { get; set; }
    public bool DocDocumentoAlquilerSegUsuarioEnUsoHabilitado { get; set; }
    public int? DocDocumentoAlquilerTerTerceroClienteIdFormaPago { get; set; }
    public int? DocDocumentoAlquilerTerTerceroClienteTiempoEntrega { get; set; }
    public string Multiempresa { get; set; } = null!;
}
