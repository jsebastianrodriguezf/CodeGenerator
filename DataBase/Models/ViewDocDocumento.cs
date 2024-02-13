using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Documento { get; set; } = null!;

    public string? DocumentoCodigo { get; set; }

    public int DocumentoNumero { get; set; }

    public string Prefijo { get; set; } = null!;

    public double Subtotal { get; set; }

    public double Descuento { get; set; }

    public double Iva { get; set; }

    public double Total { get; set; }

    public double Costo { get; set; }

    public double Rentabilidad { get; set; }

    public double Trm { get; set; }

    public DateTime FechaFh { get; set; }

    public DateTime FechaSugeridaFh { get; set; }

    public DateTime FechaCierreFf { get; set; }

    public DateTime FechaLimiteFh { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public string DocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocSubtipoDocumentoConsecutivo { get; set; }

    public int DocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocSubtipoDocumentoValUrgente { get; set; }

    public bool DocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocSubtipoDocumentoCerrarSol { get; set; }

    public bool DocSubtipoDocumentoEjecutaDevolucion { get; set; }

    public int DocSubtipoDocumentoTipoCobro { get; set; }

    public int DocSubtipoDocumentoMostrarPendienteDocumento { get; set; }

    public bool DocSubtipoDocumentoCantidadAuxiliar { get; set; }

    public bool DocSubtipoDocumentoMostrarValoresEjecutados { get; set; }

    public int DocSubtipoDocumentoArchivosAdjuntosApp { get; set; }

    public int IdTerceroCliente { get; set; }

    public string TerTerceroClienteTercero { get; set; } = null!;

    public string? TerTerceroClienteTerceroCodigo { get; set; }

    public string TerTerceroClienteTerceroNit { get; set; } = null!;

    public string? TerTerceroClienteDireccion { get; set; }

    public string? TerTerceroClienteContacto { get; set; }

    public string TerTerceroClienteTelefono { get; set; } = null!;

    public string? TerTerceroClienteFax { get; set; }

    public string? TerTerceroClienteEmail { get; set; }

    public string? TerTerceroClienteWebsite { get; set; }

    public string? TerTerceroClienteRepresentante { get; set; }

    public string? TerTerceroClienteNotas { get; set; }

    public string TerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroClienteEsCliente { get; set; }

    public bool TerTerceroClienteEsProveedor { get; set; }

    public bool TerTerceroClienteEsTransportador { get; set; }

    public bool TerTerceroClienteEsFabricante { get; set; }

    public bool TerTerceroClienteEsEmpresaPropia { get; set; }

    public string? TerTerceroClienteClasificacion { get; set; }

    public int TerTerceroClienteIdZona { get; set; }

    public int TerTerceroClienteIdEstadoTercero { get; set; }

    public int TerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool TerTerceroClienteEsProspecto { get; set; }

    public int? TerTerceroClienteIdFormaPago { get; set; }

    public int? TerTerceroClienteTiempoEntrega { get; set; }

    public int IdDocumento { get; set; }

    public string DocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoPadreIva { get; set; }

    public double DocDocumentoPadreTotal { get; set; }

    public double DocDocumentoPadreCosto { get; set; }

    public double DocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int IdTerceroProveedor { get; set; }

    public string TerTerceroProveedorTercero { get; set; } = null!;

    public string? TerTerceroProveedorTerceroCodigo { get; set; }

    public string TerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? TerTerceroProveedorDireccion { get; set; }

    public string? TerTerceroProveedorContacto { get; set; }

    public string TerTerceroProveedorTelefono { get; set; } = null!;

    public string? TerTerceroProveedorFax { get; set; }

    public string? TerTerceroProveedorEmail { get; set; }

    public string? TerTerceroProveedorWebsite { get; set; }

    public string? TerTerceroProveedorRepresentante { get; set; }

    public string? TerTerceroProveedorNotas { get; set; }

    public string TerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroProveedorEsCliente { get; set; }

    public bool TerTerceroProveedorEsProveedor { get; set; }

    public bool TerTerceroProveedorEsTransportador { get; set; }

    public bool TerTerceroProveedorEsFabricante { get; set; }

    public bool TerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? TerTerceroProveedorClasificacion { get; set; }

    public int TerTerceroProveedorIdZona { get; set; }

    public int TerTerceroProveedorIdEstadoTercero { get; set; }

    public int TerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool TerTerceroProveedorEsProspecto { get; set; }

    public int? TerTerceroProveedorIdFormaPago { get; set; }

    public int? TerTerceroProveedorTiempoEntrega { get; set; }

    public int IdPrioridadDocumento { get; set; }

    public string DocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int? DocPrioridadDocumentoOrden { get; set; }

    public int IdMoneda { get; set; }

    public string GenMonedaMoneda { get; set; } = null!;

    public string? GenMonedaMonedaCodigo { get; set; }

    public string GenMonedaAbreviatura { get; set; } = null!;

    public double GenMonedaCambio { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public string DocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocEstadoTipoDocumentoOrden { get; set; }

    public bool DocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocEstadoTipoDocumentoDescripcion { get; set; }

    public bool DocEstadoTipoDocumentoObservacionesObligatorio { get; set; }

    public bool DocEstadoTipoDocumentoMotivoObligatorio { get; set; }

    public int IdMotivoestado { get; set; }

    public string DocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double SubtotalPlaneado { get; set; }

    public double DescuentoPlaneado { get; set; }

    public double IvaPlaneado { get; set; }

    public double TotalPlaneado { get; set; }

    public double CostoPlaneado { get; set; }

    public int IdUsuarioAsignado { get; set; }

    public string SegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? SegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? SegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? SegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? SegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioAsignadoClave { get; set; }

    public string? SegUsuarioAsignadoNombre { get; set; }

    public string? SegUsuarioAsignadoProfesion { get; set; }

    public string SegUsuarioAsignadoEmail { get; set; } = null!;

    public string? SegUsuarioAsignadoDireccion { get; set; }

    public string? SegUsuarioAsignadoTelefono { get; set; }

    public decimal? SegUsuarioAsignadoCostoHora { get; set; }

    public double? SegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? SegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? SegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? SegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool SegUsuarioAsignadoSexo { get; set; }

    public int SegUsuarioAsignadoIdPerfil { get; set; }

    public int SegUsuarioAsignadoIdCargo { get; set; }

    public int SegUsuarioAsignadoIdGrupo { get; set; }

    public int SegUsuarioAsignadoIdZona { get; set; }

    public string? SegUsuarioAsignadoIdentificacion { get; set; }

    public int SegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? SegUsuarioAsignadoPreferencias { get; set; }

    public bool SegUsuarioAsignadoHabilitado { get; set; }

    public string? SegUsuarioAsignadoIdDispositivo { get; set; }

    public int IdUsuarioEnUso { get; set; }

    public string SegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? SegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? SegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? SegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? SegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioEnUsoClave { get; set; }

    public string? SegUsuarioEnUsoNombre { get; set; }

    public string? SegUsuarioEnUsoProfesion { get; set; }

    public string SegUsuarioEnUsoEmail { get; set; } = null!;

    public string? SegUsuarioEnUsoDireccion { get; set; }

    public string? SegUsuarioEnUsoTelefono { get; set; }

    public decimal? SegUsuarioEnUsoCostoHora { get; set; }

    public double? SegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? SegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? SegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? SegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool SegUsuarioEnUsoSexo { get; set; }

    public int SegUsuarioEnUsoIdPerfil { get; set; }

    public int SegUsuarioEnUsoIdCargo { get; set; }

    public int SegUsuarioEnUsoIdGrupo { get; set; }

    public int SegUsuarioEnUsoIdZona { get; set; }

    public string? SegUsuarioEnUsoIdentificacion { get; set; }

    public int SegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? SegUsuarioEnUsoPreferencias { get; set; }

    public bool SegUsuarioEnUsoHabilitado { get; set; }

    public string? SegUsuarioEnUsoIdDispositivo { get; set; }

    public string Multiempresa { get; set; } = null!;
}
