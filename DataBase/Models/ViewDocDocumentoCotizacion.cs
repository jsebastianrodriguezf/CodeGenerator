using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoCotizacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string? Telefono { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoCotizacion { get; set; } = null!;

    public int Version { get; set; }

    public int Validez { get; set; }

    public string Contacto { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public string Encabezado { get; set; } = null!;

    public string Condiciones { get; set; } = null!;

    public string Notas { get; set; } = null!;

    public bool EsAiu { get; set; }

    public double? ProcentajeA { get; set; }

    public double? ProcentajeI { get; set; }

    public double? ProcentajeU { get; set; }

    public double? ValorA { get; set; }

    public double? ValorI { get; set; }

    public double? ValorU { get; set; }

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

    public int IdUsuarioAsesor { get; set; }

    public string SegUsuarioAsesorUsuario { get; set; } = null!;

    public string? SegUsuarioAsesorUsuarioCodigo { get; set; }

    public int? SegUsuarioAsesorIntentosFallidos { get; set; }

    public int? SegUsuarioAsesorNumeroIngresos { get; set; }

    public DateTime? SegUsuarioAsesorFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioAsesorFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioAsesorClave { get; set; }

    public string? SegUsuarioAsesorNombre { get; set; }

    public string? SegUsuarioAsesorProfesion { get; set; }

    public string SegUsuarioAsesorEmail { get; set; } = null!;

    public string? SegUsuarioAsesorDireccion { get; set; }

    public string? SegUsuarioAsesorTelefono { get; set; }

    public decimal? SegUsuarioAsesorCostoHora { get; set; }

    public double? SegUsuarioAsesorPorcentajeComision { get; set; }

    public bool? SegUsuarioAsesorAccesoActivo { get; set; }

    public bool? SegUsuarioAsesorCambiarClave { get; set; }

    public DateTime? SegUsuarioAsesorFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioAsesorAplicaRecargo { get; set; }

    public bool SegUsuarioAsesorSexo { get; set; }

    public int SegUsuarioAsesorIdPerfil { get; set; }

    public int SegUsuarioAsesorIdCargo { get; set; }

    public int SegUsuarioAsesorIdGrupo { get; set; }

    public int SegUsuarioAsesorIdZona { get; set; }

    public string? SegUsuarioAsesorIdentificacion { get; set; }

    public int SegUsuarioAsesorIdUsuario { get; set; }

    public byte[]? SegUsuarioAsesorPreferencias { get; set; }

    public bool SegUsuarioAsesorHabilitado { get; set; }

    public int? DocDocumentoCotizacionDocPrioridadDocumentoOrden { get; set; }

    public string? Email { get; set; }

    public string? DocDocumentoCotizacionDocumentoCodigo { get; set; }

    public int DocDocumentoCotizacionDocumentoNumero { get; set; }

    public string DocDocumentoCotizacionPrefijo { get; set; } = null!;

    public double DocDocumentoCotizacionSubtotal { get; set; }

    public double DocDocumentoCotizacionDescuento { get; set; }

    public double DocDocumentoCotizacionIva { get; set; }

    public double DocDocumentoCotizacionTotal { get; set; }

    public double DocDocumentoCotizacionCosto { get; set; }

    public double DocDocumentoCotizacionRentabilidad { get; set; }

    public double DocDocumentoCotizacionTrm { get; set; }

    public DateTime DocDocumentoCotizacionFechaFh { get; set; }

    public DateTime DocDocumentoCotizacionFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoCotizacionFechaCierreFf { get; set; }

    public DateTime DocDocumentoCotizacionFechaLimiteFh { get; set; }

    public int DocDocumentoCotizacionIdSubtipoDocumento { get; set; }

    public string DocDocumentoCotizacionDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoCotizacionDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoCotizacionDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoCotizacionDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoCotizacionDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoCotizacionDocSubtipoDocumentoCerrarSol { get; set; }

    public int DocDocumentoCotizacionIdTerceroCliente { get; set; }

    public string DocDocumentoCotizacionTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoCotizacionTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteContacto { get; set; }

    public string DocDocumentoCotizacionTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroClienteFax { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteNotas { get; set; }

    public string DocDocumentoCotizacionTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoCotizacionTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoCotizacionTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoCotizacionTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoCotizacionTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoCotizacionTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoCotizacionTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoCotizacionTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoCotizacionTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoCotizacionTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoCotizacionTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoCotizacionIdDocumento { get; set; }

    public string DocDocumentoCotizacionDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoCotizacionDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoCotizacionDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoCotizacionDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreIva { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoCotizacionDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoCotizacionDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoCotizacionDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoCotizacionDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoCotizacionDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoCotizacionDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoCotizacionIdTerceroProveedor { get; set; }

    public string DocDocumentoCotizacionTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoCotizacionTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoCotizacionTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoCotizacionTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoCotizacionTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoCotizacionTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoCotizacionTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoCotizacionTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoCotizacionTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoCotizacionTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoCotizacionTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoCotizacionTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoCotizacionTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoCotizacionTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoCotizacionTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoCotizacionIdPrioridadDocumento { get; set; }

    public string DocDocumentoCotizacionDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoCotizacionDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoCotizacionDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoCotizacionDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoCotizacionDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int DocDocumentoCotizacionIdMoneda { get; set; }

    public string DocDocumentoCotizacionGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoCotizacionGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoCotizacionGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoCotizacionGenMonedaCambio { get; set; }

    public int DocDocumentoCotizacionIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoCotizacionDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoCotizacionDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoCotizacionDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoCotizacionDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoCotizacionDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoCotizacionDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoCotizacionDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoCotizacionDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoCotizacionDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoCotizacionDocEstadoTipoDocumentoDescripcion { get; set; }

    public int DocDocumentoCotizacionIdMotivoestado { get; set; }

    public string DocDocumentoCotizacionDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoCotizacionDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoCotizacionDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoCotizacionSubtotalPlaneado { get; set; }

    public double DocDocumentoCotizacionDescuentoPlaneado { get; set; }

    public double DocDocumentoCotizacionIvaPlaneado { get; set; }

    public double DocDocumentoCotizacionTotalPlaneado { get; set; }

    public double DocDocumentoCotizacionCostoPlaneado { get; set; }

    public int DocDocumentoCotizacionIdUsuarioAsignado { get; set; }

    public string DocDocumentoCotizacionSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoCotizacionSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoCotizacionSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoCotizacionSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoCotizacionSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoCotizacionSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoCotizacionSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoCotizacionSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoCotizacionSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoCotizacionSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoCotizacionSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoCotizacionSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoCotizacionSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoCotizacionIdUsuarioEnUso { get; set; }

    public string DocDocumentoCotizacionSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoCotizacionSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoCotizacionSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoCotizacionSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoCotizacionSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoCotizacionSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoCotizacionSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoCotizacionSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoCotizacionSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoCotizacionSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoCotizacionSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoCotizacionSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoCotizacionSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoCotizacionSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoCotizacionSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoCotizacionSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoCotizacionSegUsuarioEnUsoHabilitado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
