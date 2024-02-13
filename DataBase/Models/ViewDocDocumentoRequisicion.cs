using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoRequisicion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoRequisicion { get; set; } = null!;

    public string? TelefonoEntrega { get; set; }

    public string? DireccionEntrega { get; set; }

    public string? Asunto { get; set; }

    public string? Observaciones { get; set; }

    public string? Solicitante { get; set; }

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

    public int? DocDocumentoRequisicionDocPrioridadDocumentoOrden { get; set; }

    public string? DocDocumentoRequisicionDocumentoCodigo { get; set; }

    public int DocDocumentoRequisicionDocumentoNumero { get; set; }

    public string DocDocumentoRequisicionPrefijo { get; set; } = null!;

    public double DocDocumentoRequisicionSubtotal { get; set; }

    public double DocDocumentoRequisicionDescuento { get; set; }

    public double DocDocumentoRequisicionIva { get; set; }

    public double DocDocumentoRequisicionTotal { get; set; }

    public double DocDocumentoRequisicionCosto { get; set; }

    public double DocDocumentoRequisicionRentabilidad { get; set; }

    public double DocDocumentoRequisicionTrm { get; set; }

    public DateTime DocDocumentoRequisicionFechaFh { get; set; }

    public DateTime DocDocumentoRequisicionFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoRequisicionFechaCierreFf { get; set; }

    public DateTime DocDocumentoRequisicionFechaLimiteFh { get; set; }

    public int DocDocumentoRequisicionIdSubtipoDocumento { get; set; }

    public string DocDocumentoRequisicionDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoRequisicionDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoRequisicionDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoRequisicionDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoRequisicionDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoRequisicionDocSubtipoDocumentoCerrarSol { get; set; }

    public int DocDocumentoRequisicionIdTerceroCliente { get; set; }

    public string DocDocumentoRequisicionTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoRequisicionTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteContacto { get; set; }

    public string DocDocumentoRequisicionTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroClienteFax { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteNotas { get; set; }

    public string DocDocumentoRequisicionTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoRequisicionTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoRequisicionTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoRequisicionTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoRequisicionTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoRequisicionTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoRequisicionTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoRequisicionTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoRequisicionTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoRequisicionTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoRequisicionTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoRequisicionIdDocumento { get; set; }

    public string DocDocumentoRequisicionDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoRequisicionDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoRequisicionDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoRequisicionDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreIva { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoRequisicionDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoRequisicionDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoRequisicionDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoRequisicionDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoRequisicionDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoRequisicionDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoRequisicionIdTerceroProveedor { get; set; }

    public string DocDocumentoRequisicionTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoRequisicionTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoRequisicionTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoRequisicionTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoRequisicionTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoRequisicionTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoRequisicionTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoRequisicionTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoRequisicionTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoRequisicionTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoRequisicionTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoRequisicionTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoRequisicionTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoRequisicionTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoRequisicionTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoRequisicionIdPrioridadDocumento { get; set; }

    public string DocDocumentoRequisicionDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoRequisicionDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoRequisicionDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoRequisicionDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoRequisicionDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int DocDocumentoRequisicionIdMoneda { get; set; }

    public string DocDocumentoRequisicionGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoRequisicionGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoRequisicionGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoRequisicionGenMonedaCambio { get; set; }

    public int DocDocumentoRequisicionIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoRequisicionDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoRequisicionDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoRequisicionDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoRequisicionDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoRequisicionDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoRequisicionDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoRequisicionDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoRequisicionDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoRequisicionDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoRequisicionDocEstadoTipoDocumentoDescripcion { get; set; }

    public int DocDocumentoRequisicionIdMotivoestado { get; set; }

    public string DocDocumentoRequisicionDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoRequisicionDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoRequisicionDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoRequisicionSubtotalPlaneado { get; set; }

    public double DocDocumentoRequisicionDescuentoPlaneado { get; set; }

    public double DocDocumentoRequisicionIvaPlaneado { get; set; }

    public double DocDocumentoRequisicionTotalPlaneado { get; set; }

    public double DocDocumentoRequisicionCostoPlaneado { get; set; }

    public int DocDocumentoRequisicionIdUsuarioAsignado { get; set; }

    public string DocDocumentoRequisicionSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoRequisicionSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoRequisicionSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoRequisicionSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoRequisicionSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoRequisicionSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoRequisicionSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoRequisicionSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoRequisicionSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoRequisicionSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoRequisicionSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoRequisicionSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoRequisicionSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoRequisicionIdUsuarioEnUso { get; set; }

    public string DocDocumentoRequisicionSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoRequisicionSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoRequisicionSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoRequisicionSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoRequisicionSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoRequisicionSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoRequisicionSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoRequisicionSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoRequisicionSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoRequisicionSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoRequisicionSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoRequisicionSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoRequisicionSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoRequisicionSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoRequisicionSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoRequisicionSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoRequisicionSegUsuarioEnUsoHabilitado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
