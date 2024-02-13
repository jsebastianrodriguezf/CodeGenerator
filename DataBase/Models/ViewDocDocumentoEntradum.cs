using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoEntradum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoEntrada { get; set; } = null!;

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

    public bool EsPorAjuste { get; set; }

    public string? DocDocumentoEntradaDocumentoCodigo { get; set; }

    public int DocDocumentoEntradaDocumentoNumero { get; set; }

    public string DocDocumentoEntradaPrefijo { get; set; } = null!;

    public double DocDocumentoEntradaSubtotal { get; set; }

    public double DocDocumentoEntradaDescuento { get; set; }

    public double DocDocumentoEntradaIva { get; set; }

    public double DocDocumentoEntradaTotal { get; set; }

    public double DocDocumentoEntradaCosto { get; set; }

    public double DocDocumentoEntradaRentabilidad { get; set; }

    public double DocDocumentoEntradaTrm { get; set; }

    public DateTime DocDocumentoEntradaFechaFh { get; set; }

    public DateTime DocDocumentoEntradaFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoEntradaFechaCierreFf { get; set; }

    public DateTime DocDocumentoEntradaFechaLimiteFh { get; set; }

    public int DocDocumentoEntradaIdSubtipoDocumento { get; set; }

    public string DocDocumentoEntradaDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoEntradaDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoEntradaDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoEntradaDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoEntradaDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoEntradaDocSubtipoDocumentoCerrarSol { get; set; }

    public int DocDocumentoEntradaDocSubtipoDocumentoTipoCobro { get; set; }

    public int DocDocumentoEntradaIdTerceroCliente { get; set; }

    public string DocDocumentoEntradaTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoEntradaTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteContacto { get; set; }

    public string DocDocumentoEntradaTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroClienteFax { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteNotas { get; set; }

    public string DocDocumentoEntradaTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoEntradaTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoEntradaTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoEntradaTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoEntradaTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoEntradaTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoEntradaTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoEntradaTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoEntradaTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoEntradaTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoEntradaTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoEntradaIdDocumento { get; set; }

    public string DocDocumentoEntradaDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoEntradaDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoEntradaDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoEntradaDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreIva { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoEntradaDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoEntradaDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoEntradaDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoEntradaDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoEntradaDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoEntradaDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoEntradaIdTerceroProveedor { get; set; }

    public string DocDocumentoEntradaTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoEntradaTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoEntradaTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoEntradaTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoEntradaTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoEntradaTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoEntradaTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoEntradaTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoEntradaTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoEntradaTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoEntradaTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoEntradaTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoEntradaTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoEntradaTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoEntradaTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoEntradaIdPrioridadDocumento { get; set; }

    public string DocDocumentoEntradaDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoEntradaDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoEntradaDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoEntradaDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoEntradaDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int DocDocumentoEntradaIdMoneda { get; set; }

    public string DocDocumentoEntradaGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoEntradaGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoEntradaGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoEntradaGenMonedaCambio { get; set; }

    public int DocDocumentoEntradaIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoEntradaDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoEntradaDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoEntradaDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoEntradaDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoEntradaDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoEntradaDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoEntradaDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoEntradaDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoEntradaDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoEntradaDocEstadoTipoDocumentoDescripcion { get; set; }

    public int DocDocumentoEntradaIdMotivoestado { get; set; }

    public string DocDocumentoEntradaDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoEntradaDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoEntradaDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoEntradaSubtotalPlaneado { get; set; }

    public double DocDocumentoEntradaDescuentoPlaneado { get; set; }

    public double DocDocumentoEntradaIvaPlaneado { get; set; }

    public double DocDocumentoEntradaTotalPlaneado { get; set; }

    public double DocDocumentoEntradaCostoPlaneado { get; set; }

    public int DocDocumentoEntradaIdUsuarioAsignado { get; set; }

    public string DocDocumentoEntradaSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoEntradaSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoEntradaSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoEntradaSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoEntradaSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoEntradaSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoEntradaSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoEntradaSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoEntradaSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoEntradaSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoEntradaSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoEntradaSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoEntradaSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoEntradaSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoEntradaSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoEntradaSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoEntradaSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoEntradaSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoEntradaSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoEntradaSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoEntradaSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoEntradaSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoEntradaSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoEntradaSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoEntradaIdUsuarioEnUso { get; set; }

    public string DocDocumentoEntradaSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoEntradaSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoEntradaSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoEntradaSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoEntradaSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoEntradaSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoEntradaSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoEntradaSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoEntradaSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoEntradaSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoEntradaSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoEntradaSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoEntradaSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoEntradaSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoEntradaSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoEntradaSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoEntradaSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoEntradaSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoEntradaSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoEntradaSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoEntradaSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoEntradaSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoEntradaSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoEntradaSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoEntradaSegUsuarioEnUsoHabilitado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
