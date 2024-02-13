using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoOrdenCompra
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOrdenCompra { get; set; } = null!;

    public string? TelefonoEntrega { get; set; }

    public string? DireccionEntrega { get; set; }

    public string? Asunto { get; set; }

    public string? Observaciones { get; set; }

    public DateTime FechaPagoFf { get; set; }

    public string? Solicitante { get; set; }

    public int IdFormaPago { get; set; }

    public string DocFormaPagoFormaPago { get; set; } = null!;

    public string? DocFormaPagoFormaPagoCodigo { get; set; }

    public int? DocFormapagoDiaspago { get; set; }

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

    public string? DocDocumentoOrdenCompraDocumentoCodigo { get; set; }

    public int DocDocumentoOrdenCompraDocumentoNumero { get; set; }

    public string DocDocumentoOrdenCompraPrefijo { get; set; } = null!;

    public double DocDocumentoOrdenCompraSubtotal { get; set; }

    public double DocDocumentoOrdenCompraDescuento { get; set; }

    public double DocDocumentoOrdenCompraIva { get; set; }

    public double DocDocumentoOrdenCompraTotal { get; set; }

    public double DocDocumentoOrdenCompraCosto { get; set; }

    public double DocDocumentoOrdenCompraRentabilidad { get; set; }

    public double DocDocumentoOrdenCompraTrm { get; set; }

    public DateTime DocDocumentoOrdenCompraFechaFh { get; set; }

    public DateTime DocDocumentoOrdenCompraFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOrdenCompraFechaCierreFf { get; set; }

    public DateTime DocDocumentoOrdenCompraFechaLimiteFh { get; set; }

    public int DocDocumentoOrdenCompraIdSubtipoDocumento { get; set; }

    public int? DocDocumentoOrdenCompraDocPrioridadDocumentoOrden { get; set; }

    public string DocDocumentoOrdenCompraDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoOrdenCompraDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoOrdenCompraDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoOrdenCompraDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoOrdenCompraDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoOrdenCompraDocSubtipoDocumentoCerrarSol { get; set; }

    public int DocDocumentoOrdenCompraIdTerceroCliente { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteContacto { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroClienteFax { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteNotas { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoOrdenCompraIdDocumento { get; set; }

    public string DocDocumentoOrdenCompraDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoOrdenCompraDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoOrdenCompraDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoOrdenCompraDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreIva { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoOrdenCompraDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoOrdenCompraDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOrdenCompraDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoOrdenCompraDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoOrdenCompraDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoOrdenCompraDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoOrdenCompraIdTerceroProveedor { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoOrdenCompraTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoOrdenCompraTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoOrdenCompraTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoOrdenCompraTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoOrdenCompraTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoOrdenCompraIdPrioridadDocumento { get; set; }

    public string DocDocumentoOrdenCompraDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoOrdenCompraDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoOrdenCompraDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoOrdenCompraDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int DocDocumentoOrdenCompraIdMoneda { get; set; }

    public string DocDocumentoOrdenCompraGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoOrdenCompraGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoOrdenCompraGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoOrdenCompraGenMonedaCambio { get; set; }

    public int DocDocumentoOrdenCompraIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoOrdenCompraDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoOrdenCompraDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoOrdenCompraDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoOrdenCompraDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoOrdenCompraDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoOrdenCompraDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoOrdenCompraDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoOrdenCompraDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoOrdenCompraDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoOrdenCompraDocEstadoTipoDocumentoDescripcion { get; set; }

    public int DocDocumentoOrdenCompraIdMotivoestado { get; set; }

    public string DocDocumentoOrdenCompraDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoOrdenCompraDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoOrdenCompraDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoOrdenCompraSubtotalPlaneado { get; set; }

    public double DocDocumentoOrdenCompraDescuentoPlaneado { get; set; }

    public double DocDocumentoOrdenCompraIvaPlaneado { get; set; }

    public double DocDocumentoOrdenCompraTotalPlaneado { get; set; }

    public double DocDocumentoOrdenCompraCostoPlaneado { get; set; }

    public int DocDocumentoOrdenCompraIdUsuarioAsignado { get; set; }

    public string DocDocumentoOrdenCompraSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoOrdenCompraSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoOrdenCompraSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoOrdenCompraSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoOrdenCompraSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoOrdenCompraSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoOrdenCompraSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoOrdenCompraSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoOrdenCompraSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoOrdenCompraIdUsuarioEnUso { get; set; }

    public string DocDocumentoOrdenCompraSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoOrdenCompraSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoOrdenCompraSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoOrdenCompraSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoOrdenCompraSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoOrdenCompraSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoOrdenCompraSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoOrdenCompraSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoOrdenCompraSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoOrdenCompraSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoOrdenCompraSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoOrdenCompraSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoOrdenCompraSegUsuarioEnUsoHabilitado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
