namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoProyectoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoProyecto { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicioEstimada { get; set; }
    public DateTime FechaFinEstimada { get; set; }
    public string? Descripcion { get; set; }
    public decimal? Presupuesto { get; set; }
    public string? DocDocumentoProyectoDocumentoCodigo { get; set; }
    public int DocDocumentoProyectoDocumentoNumero { get; set; }
    public string DocDocumentoProyectoPrefijo { get; set; } = null!;
    public double DocDocumentoProyectoSubtotal { get; set; }
    public double DocDocumentoProyectoDescuento { get; set; }
    public double DocDocumentoProyectoIva { get; set; }
    public double DocDocumentoProyectoTotal { get; set; }
    public double DocDocumentoProyectoCosto { get; set; }
    public double DocDocumentoProyectoRentabilidad { get; set; }
    public double DocDocumentoProyectoTrm { get; set; }
    public DateTime DocDocumentoProyectoFechaFh { get; set; }
    public DateTime DocDocumentoProyectoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoProyectoFechaCierreFf { get; set; }
    public DateTime DocDocumentoProyectoFechaLimiteFh { get; set; }
    public int? DocDocumentoProyectoDocPrioridadDocumentoOrden { get; set; }
    public int DocDocumentoProyectoIdSubtipoDocumento { get; set; }
    public string DocDocumentoProyectoDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;
    public string? DocDocumentoProyectoDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }
    public string DocDocumentoProyectoDocSubtipoDocumentoPrefijo { get; set; } = null!;
    public int DocDocumentoProyectoDocSubtipoDocumentoConsecutivo { get; set; }
    public int DocDocumentoProyectoDocSubtipoDocumentoIdTipoDocumento { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoProgramarPlaneadas { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoCargarSolicitante { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoVerCentroCosto { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoVerIncoterm { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoValUrgente { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoBloquearDespacho { get; set; }
    public bool DocDocumentoProyectoDocSubtipoDocumentoCerrarSol { get; set; }
    public int DocDocumentoProyectoIdTerceroCliente { get; set; }
    public string DocDocumentoProyectoTerTerceroClienteTercero { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroClienteTerceroCodigo { get; set; }
    public string DocDocumentoProyectoTerTerceroClienteTerceroNit { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroClienteDireccion { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteContacto { get; set; }
    public string DocDocumentoProyectoTerTerceroClienteTelefono { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroClienteFax { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteEmail { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteWebsite { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteRepresentante { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteNotas { get; set; }
    public string DocDocumentoProyectoTerTerceroClienteTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoProyectoTerTerceroClienteEsCliente { get; set; }
    public bool DocDocumentoProyectoTerTerceroClienteEsProveedor { get; set; }
    public bool DocDocumentoProyectoTerTerceroClienteEsTransportador { get; set; }
    public bool DocDocumentoProyectoTerTerceroClienteEsFabricante { get; set; }
    public bool DocDocumentoProyectoTerTerceroClienteEsEmpresaPropia { get; set; }
    public string? DocDocumentoProyectoTerTerceroClienteClasificacion { get; set; }
    public int DocDocumentoProyectoTerTerceroClienteIdZona { get; set; }
    public int DocDocumentoProyectoTerTerceroClienteIdEstadoTercero { get; set; }
    public int DocDocumentoProyectoTerTerceroClienteIdNaturalezaTercero { get; set; }
    public bool DocDocumentoProyectoTerTerceroClienteEsProspecto { get; set; }
    public int DocDocumentoProyectoIdDocumento { get; set; }
    public string DocDocumentoProyectoDocDocumentoPadreDocumento { get; set; } = null!;
    public string? DocDocumentoProyectoDocDocumentoPadreDocumentoCodigo { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreDocumentoNumero { get; set; }
    public string DocDocumentoProyectoDocDocumentoPadrePrefijo { get; set; } = null!;
    public double DocDocumentoProyectoDocDocumentoPadreSubtotal { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreDescuento { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreIva { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreTotal { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreCosto { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreRentabilidad { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreTrm { get; set; }
    public DateTime DocDocumentoProyectoDocDocumentoPadreFechaFh { get; set; }
    public DateTime DocDocumentoProyectoDocDocumentoPadreFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoProyectoDocDocumentoPadreFechaCierreFf { get; set; }
    public DateTime DocDocumentoProyectoDocDocumentoPadreFechaLimiteFh { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdSubtipoDocumento { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdTerceroCliente { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdDocumento { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdTerceroProveedor { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdPrioridadDocumento { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdMoneda { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdMotivoestado { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreSubtotalPlaneado { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreDescuentoPlaneado { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreIvaPlaneado { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreTotalPlaneado { get; set; }
    public double DocDocumentoProyectoDocDocumentoPadreCostoPlaneado { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdUsuarioAsignado { get; set; }
    public int DocDocumentoProyectoDocDocumentoPadreIdUsuarioEnUso { get; set; }
    public int DocDocumentoProyectoIdTerceroProveedor { get; set; }
    public string DocDocumentoProyectoTerTerceroProveedorTercero { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroProveedorTerceroCodigo { get; set; }
    public string DocDocumentoProyectoTerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroProveedorDireccion { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorContacto { get; set; }
    public string DocDocumentoProyectoTerTerceroProveedorTelefono { get; set; } = null!;
    public string? DocDocumentoProyectoTerTerceroProveedorFax { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorEmail { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorWebsite { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorRepresentante { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorNotas { get; set; }
    public string DocDocumentoProyectoTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool DocDocumentoProyectoTerTerceroProveedorEsCliente { get; set; }
    public bool DocDocumentoProyectoTerTerceroProveedorEsProveedor { get; set; }
    public bool DocDocumentoProyectoTerTerceroProveedorEsTransportador { get; set; }
    public bool DocDocumentoProyectoTerTerceroProveedorEsFabricante { get; set; }
    public bool DocDocumentoProyectoTerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? DocDocumentoProyectoTerTerceroProveedorClasificacion { get; set; }
    public int DocDocumentoProyectoTerTerceroProveedorIdZona { get; set; }
    public int DocDocumentoProyectoTerTerceroProveedorIdEstadoTercero { get; set; }
    public int DocDocumentoProyectoTerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool DocDocumentoProyectoTerTerceroProveedorEsProspecto { get; set; }
    public int DocDocumentoProyectoIdPrioridadDocumento { get; set; }
    public string DocDocumentoProyectoDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocDocumentoProyectoDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocDocumentoProyectoDocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocDocumentoProyectoDocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocDocumentoProyectoDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int DocDocumentoProyectoIdMoneda { get; set; }
    public string DocDocumentoProyectoGenMonedaMoneda { get; set; } = null!;
    public string? DocDocumentoProyectoGenMonedaMonedaCodigo { get; set; }
    public string DocDocumentoProyectoGenMonedaAbreviatura { get; set; } = null!;
    public double DocDocumentoProyectoGenMonedaCambio { get; set; }
    public int DocDocumentoProyectoIdEstadoTipoDocumento { get; set; }
    public string DocDocumentoProyectoDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? DocDocumentoProyectoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocDocumentoProyectoDocEstadoTipoDocumentoAfectaIndicador { get; set; }
    public bool DocDocumentoProyectoDocEstadoTipoDocumentoEditaDocumento { get; set; }
    public int DocDocumentoProyectoDocEstadoTipoDocumentoOrden { get; set; }
    public bool DocDocumentoProyectoDocEstadoTipoDocumentoPuedeRegresar { get; set; }
    public string DocDocumentoProyectoDocEstadoTipoDocumentoColor { get; set; } = null!;
    public bool DocDocumentoProyectoDocEstadoTipoDocumentoAfectaInventario { get; set; }
    public int DocDocumentoProyectoDocEstadoTipoDocumentoIdTipoDocumento { get; set; }
    public string? DocDocumentoProyectoDocEstadoTipoDocumentoDescripcion { get; set; }
    public int DocDocumentoProyectoIdMotivoestado { get; set; }
    public string DocDocumentoProyectoDocMotivoestadoMotivoestado { get; set; } = null!;
    public string? DocDocumentoProyectoDocMotivoestadoMotivoestadoCodigo { get; set; }
    public int DocDocumentoProyectoDocMotivoestadoIdEstadoTipoDocumento { get; set; }
    public double DocDocumentoProyectoSubtotalPlaneado { get; set; }
    public double DocDocumentoProyectoDescuentoPlaneado { get; set; }
    public double DocDocumentoProyectoIvaPlaneado { get; set; }
    public double DocDocumentoProyectoTotalPlaneado { get; set; }
    public double DocDocumentoProyectoCostoPlaneado { get; set; }
    public int DocDocumentoProyectoIdUsuarioAsignado { get; set; }
    public string DocDocumentoProyectoSegUsuarioAsignadoUsuario { get; set; } = null!;
    public string? DocDocumentoProyectoSegUsuarioAsignadoUsuarioCodigo { get; set; }
    public int? DocDocumentoProyectoSegUsuarioAsignadoIntentosFallidos { get; set; }
    public int? DocDocumentoProyectoSegUsuarioAsignadoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoProyectoSegUsuarioAsignadoClave { get; set; }
    public string? DocDocumentoProyectoSegUsuarioAsignadoNombre { get; set; }
    public string? DocDocumentoProyectoSegUsuarioAsignadoProfesion { get; set; }
    public string DocDocumentoProyectoSegUsuarioAsignadoEmail { get; set; } = null!;
    public string? DocDocumentoProyectoSegUsuarioAsignadoDireccion { get; set; }
    public string? DocDocumentoProyectoSegUsuarioAsignadoTelefono { get; set; }
    public decimal? DocDocumentoProyectoSegUsuarioAsignadoCostoHora { get; set; }
    public double? DocDocumentoProyectoSegUsuarioAsignadoPorcentajeComision { get; set; }
    public bool? DocDocumentoProyectoSegUsuarioAsignadoAccesoActivo { get; set; }
    public bool? DocDocumentoProyectoSegUsuarioAsignadoCambiarClave { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoProyectoSegUsuarioAsignadoAplicaRecargo { get; set; }
    public bool DocDocumentoProyectoSegUsuarioAsignadoSexo { get; set; }
    public int DocDocumentoProyectoSegUsuarioAsignadoIdPerfil { get; set; }
    public int DocDocumentoProyectoSegUsuarioAsignadoIdCargo { get; set; }
    public int DocDocumentoProyectoSegUsuarioAsignadoIdGrupo { get; set; }
    public int DocDocumentoProyectoSegUsuarioAsignadoIdZona { get; set; }
    public string? DocDocumentoProyectoSegUsuarioAsignadoIdentificacion { get; set; }
    public int DocDocumentoProyectoSegUsuarioAsignadoIdUsuario { get; set; }
    public byte[]? DocDocumentoProyectoSegUsuarioAsignadoPreferencias { get; set; }
    public bool DocDocumentoProyectoSegUsuarioAsignadoHabilitado { get; set; }
    public int DocDocumentoProyectoIdUsuarioEnUso { get; set; }
    public string DocDocumentoProyectoSegUsuarioEnUsoUsuario { get; set; } = null!;
    public string? DocDocumentoProyectoSegUsuarioEnUsoUsuarioCodigo { get; set; }
    public int? DocDocumentoProyectoSegUsuarioEnUsoIntentosFallidos { get; set; }
    public int? DocDocumentoProyectoSegUsuarioEnUsoNumeroIngresos { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }
    public string? DocDocumentoProyectoSegUsuarioEnUsoClave { get; set; }
    public string? DocDocumentoProyectoSegUsuarioEnUsoNombre { get; set; }
    public string? DocDocumentoProyectoSegUsuarioEnUsoProfesion { get; set; }
    public string DocDocumentoProyectoSegUsuarioEnUsoEmail { get; set; } = null!;
    public string? DocDocumentoProyectoSegUsuarioEnUsoDireccion { get; set; }
    public string? DocDocumentoProyectoSegUsuarioEnUsoTelefono { get; set; }
    public decimal? DocDocumentoProyectoSegUsuarioEnUsoCostoHora { get; set; }
    public double? DocDocumentoProyectoSegUsuarioEnUsoPorcentajeComision { get; set; }
    public bool? DocDocumentoProyectoSegUsuarioEnUsoAccesoActivo { get; set; }
    public bool? DocDocumentoProyectoSegUsuarioEnUsoCambiarClave { get; set; }
    public DateTime? DocDocumentoProyectoSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }
    public bool DocDocumentoProyectoSegUsuarioEnUsoAplicaRecargo { get; set; }
    public bool DocDocumentoProyectoSegUsuarioEnUsoSexo { get; set; }
    public int DocDocumentoProyectoSegUsuarioEnUsoIdPerfil { get; set; }
    public int DocDocumentoProyectoSegUsuarioEnUsoIdCargo { get; set; }
    public int DocDocumentoProyectoSegUsuarioEnUsoIdGrupo { get; set; }
    public int DocDocumentoProyectoSegUsuarioEnUsoIdZona { get; set; }
    public string? DocDocumentoProyectoSegUsuarioEnUsoIdentificacion { get; set; }
    public int DocDocumentoProyectoSegUsuarioEnUsoIdUsuario { get; set; }
    public byte[]? DocDocumentoProyectoSegUsuarioEnUsoPreferencias { get; set; }
    public bool DocDocumentoProyectoSegUsuarioEnUsoHabilitado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
