using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoGasto { get; set; } = null!;

    public DateTime FechaFf { get; set; }

    public int Dias { get; set; }

    public string Concepto { get; set; } = null!;

    public bool Consignado { get; set; }

    public int IdUsuarioSolicitante { get; set; }

    public string SegUsuarioSolicitanteUsuario { get; set; } = null!;

    public string? SegUsuarioSolicitanteUsuarioCodigo { get; set; }

    public int? SegUsuarioSolicitanteIntentosFallidos { get; set; }

    public int? SegUsuarioSolicitanteNumeroIngresos { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioSolicitanteClave { get; set; }

    public string? SegUsuarioSolicitanteNombre { get; set; }

    public string? SegUsuarioSolicitanteProfesion { get; set; }

    public string SegUsuarioSolicitanteEmail { get; set; } = null!;

    public string? SegUsuarioSolicitanteDireccion { get; set; }

    public string? SegUsuarioSolicitanteTelefono { get; set; }

    public decimal? SegUsuarioSolicitanteCostoHora { get; set; }

    public double? SegUsuarioSolicitantePorcentajeComision { get; set; }

    public bool? SegUsuarioSolicitanteAccesoActivo { get; set; }

    public bool? SegUsuarioSolicitanteCambiarClave { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioSolicitanteAplicaRecargo { get; set; }

    public bool SegUsuarioSolicitanteSexo { get; set; }

    public int SegUsuarioSolicitanteIdPerfil { get; set; }

    public int SegUsuarioSolicitanteIdCargo { get; set; }

    public int SegUsuarioSolicitanteIdGrupo { get; set; }

    public int SegUsuarioSolicitanteIdZona { get; set; }

    public string? SegUsuarioSolicitanteIdentificacion { get; set; }

    public int SegUsuarioSolicitanteIdUsuario { get; set; }

    public byte[]? SegUsuarioSolicitantePreferencias { get; set; }

    public bool SegUsuarioSolicitanteHabilitado { get; set; }

    public string? DocDocumentoGastoDocumentoCodigo { get; set; }

    public int DocDocumentoGastoDocumentoNumero { get; set; }

    public string DocDocumentoGastoPrefijo { get; set; } = null!;

    public double DocDocumentoGastoSubtotal { get; set; }

    public double DocDocumentoGastoDescuento { get; set; }

    public double DocDocumentoGastoIva { get; set; }

    public double DocDocumentoGastoTotal { get; set; }

    public double DocDocumentoGastoCosto { get; set; }

    public double DocDocumentoGastoRentabilidad { get; set; }

    public double DocDocumentoGastoTrm { get; set; }

    public DateTime DocDocumentoGastoFechaFh { get; set; }

    public DateTime DocDocumentoGastoFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoGastoFechaCierreFf { get; set; }

    public DateTime DocDocumentoGastoFechaLimiteFh { get; set; }

    public int DocDocumentoGastoIdSubtipoDocumento { get; set; }

    public string DocDocumentoGastoDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoGastoDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoGastoDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoGastoDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoGastoDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoCerrarSol { get; set; }

    public bool DocDocumentoGastoDocSubtipoDocumentoEjecutaDevolucion { get; set; }

    public int DocDocumentoGastoDocSubtipoDocumentoTipoCobro { get; set; }

    public int DocDocumentoGastoIdTerceroCliente { get; set; }

    public string DocDocumentoGastoTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoGastoTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteContacto { get; set; }

    public string DocDocumentoGastoTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroClienteFax { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteNotas { get; set; }

    public string DocDocumentoGastoTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoGastoTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoGastoTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoGastoTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoGastoTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoGastoTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoGastoTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoGastoTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoGastoTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoGastoTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoGastoTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoGastoIdDocumento { get; set; }

    public string DocDocumentoGastoDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoGastoDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoGastoDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoGastoDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreIva { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoGastoDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoGastoDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoGastoDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoGastoDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoGastoDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoGastoDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoGastoIdTerceroProveedor { get; set; }

    public string DocDocumentoGastoTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoGastoTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoGastoTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoGastoTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoGastoTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoGastoTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoGastoTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoGastoTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoGastoTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoGastoTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoGastoTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoGastoTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoGastoTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoGastoTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoGastoTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoGastoIdPrioridadDocumento { get; set; }

    public string DocDocumentoGastoDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoGastoDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoGastoDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoGastoDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoGastoDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int? DocDocumentoGastoDocPrioridadDocumentoOrden { get; set; }

    public int DocDocumentoGastoIdMoneda { get; set; }

    public string DocDocumentoGastoGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoGastoGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoGastoGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoGastoGenMonedaCambio { get; set; }

    public int DocDocumentoGastoIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoGastoDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoGastoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoGastoDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoGastoDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoGastoDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoGastoDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoGastoDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoGastoDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoGastoDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoGastoDocEstadoTipoDocumentoDescripcion { get; set; }

    public bool DocDocumentoGastoDocEstadoTipoDocumentoObservacionesObligatorio { get; set; }

    public bool DocDocumentoGastoDocEstadoTipoDocumentoMotivoObligatorio { get; set; }

    public int DocDocumentoGastoIdMotivoestado { get; set; }

    public string DocDocumentoGastoDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoGastoDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoGastoDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoGastoSubtotalPlaneado { get; set; }

    public double DocDocumentoGastoDescuentoPlaneado { get; set; }

    public double DocDocumentoGastoIvaPlaneado { get; set; }

    public double DocDocumentoGastoTotalPlaneado { get; set; }

    public double DocDocumentoGastoCostoPlaneado { get; set; }

    public int DocDocumentoGastoIdUsuarioAsignado { get; set; }

    public string DocDocumentoGastoSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoGastoSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoGastoSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoGastoSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoGastoSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoGastoSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoGastoSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoGastoSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoGastoSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoGastoSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoGastoSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoGastoSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoGastoSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoGastoSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoGastoSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoGastoSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoGastoSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoGastoSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoGastoSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoGastoSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoGastoSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoGastoSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoGastoSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoGastoSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoGastoIdUsuarioEnUso { get; set; }

    public string DocDocumentoGastoSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoGastoSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoGastoSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoGastoSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoGastoSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoGastoSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoGastoSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoGastoSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoGastoSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoGastoSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoGastoSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoGastoSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoGastoSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoGastoSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoGastoSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoGastoSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoGastoSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoGastoSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoGastoSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoGastoSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoGastoSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoGastoSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoGastoSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoGastoSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoGastoSegUsuarioEnUsoHabilitado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
