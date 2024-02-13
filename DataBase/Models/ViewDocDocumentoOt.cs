using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoOt
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOt { get; set; } = null!;

    public string MotivoServicio { get; set; } = null!;

    public bool EnTaller { get; set; }

    public string? DiagnosticoInicial { get; set; }

    public string Contacto { get; set; } = null!;

    public string? Cargo { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? DireccionUbicacion { get; set; }

    public double DuracionEstimada { get; set; }

    public DateTime? FechaGarantiaFf { get; set; }

    public DateTime FechaCompromisoFh { get; set; }

    public string? Trabajos { get; set; }

    public string? Recomendaciones { get; set; }

    public string? Compromisos { get; set; }

    public string? ReclamacionFabrica { get; set; }

    public double? PorcentajeCliente { get; set; }

    public double? PorcentajeDistribuidor { get; set; }

    public double? PorcentajeFabricante { get; set; }

    public bool? SegunTempario { get; set; }

    public bool? DistribuyeCentros { get; set; }

    public int IdTipoServicio { get; set; }

    public string GenTipoServicioTipoServicio { get; set; } = null!;

    public string? GenTipoServicioTipoServicioCodigo { get; set; }

    public bool? GenTipoServicioTieneGarantia { get; set; }

    public int? GenTipoServicioDiasGarantia { get; set; }

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

    public int IdUsuarioCoordinador { get; set; }

    public string SegUsuarioCoordinadorUsuario { get; set; } = null!;

    public string? SegUsuarioCoordinadorUsuarioCodigo { get; set; }

    public int? SegUsuarioCoordinadorIntentosFallidos { get; set; }

    public int? SegUsuarioCoordinadorNumeroIngresos { get; set; }

    public DateTime? SegUsuarioCoordinadorFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioCoordinadorFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioCoordinadorClave { get; set; }

    public string? SegUsuarioCoordinadorNombre { get; set; }

    public string? SegUsuarioCoordinadorProfesion { get; set; }

    public string SegUsuarioCoordinadorEmail { get; set; } = null!;

    public string? SegUsuarioCoordinadorDireccion { get; set; }

    public string? SegUsuarioCoordinadorTelefono { get; set; }

    public decimal? SegUsuarioCoordinadorCostoHora { get; set; }

    public double? SegUsuarioCoordinadorPorcentajeComision { get; set; }

    public bool? SegUsuarioCoordinadorAccesoActivo { get; set; }

    public bool? SegUsuarioCoordinadorCambiarClave { get; set; }

    public DateTime? SegUsuarioCoordinadorFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioCoordinadorAplicaRecargo { get; set; }

    public bool SegUsuarioCoordinadorSexo { get; set; }

    public int SegUsuarioCoordinadorIdPerfil { get; set; }

    public int SegUsuarioCoordinadorIdCargo { get; set; }

    public int SegUsuarioCoordinadorIdGrupo { get; set; }

    public int SegUsuarioCoordinadorIdZona { get; set; }

    public string? SegUsuarioCoordinadorIdentificacion { get; set; }

    public int SegUsuarioCoordinadorIdUsuario { get; set; }

    public byte[]? SegUsuarioCoordinadorPreferencias { get; set; }

    public bool SegUsuarioCoordinadorHabilitado { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public string OrtMotivoCancelacionMotivoCancelacion { get; set; } = null!;

    public string? OrtMotivoCancelacionMotivoCancelacionCodigo { get; set; }

    public bool? OrtMotivoCancelacionResponsableServicio { get; set; }

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

    public int IdSistema { get; set; }

    public string CatSistemaSistema { get; set; } = null!;

    public string? CatSistemaSistemaCodigo { get; set; }

    public int CatSistemaIdSistema { get; set; }

    public int IdDepartamentoSolicitud { get; set; }

    public string OrtDepartamentoSolicitudDepartamentoSolicitud { get; set; } = null!;

    public string? OrtDepartamentoSolicitudDepartamentoSolicitudCodigo { get; set; }

    public bool OrtDepartamentoSolicitudRecibeSolicitudes { get; set; }

    public int IdContrato { get; set; }

    public string CntContratoContrato { get; set; } = null!;

    public string? CntContratoContratoCodigo { get; set; }

    public string CntContratoNumero { get; set; } = null!;

    public decimal? CntContratoTotalContrato { get; set; }

    public decimal? CntContratoPresupuesto { get; set; }

    public DateTime CntContratoFechaInicioFf { get; set; }

    public DateTime? CntContratoFechaFinFf { get; set; }

    public int? CntContratoDiasCumplimiento { get; set; }

    public string? CntContratoCondiciones { get; set; }

    public int CntContratoIdPeriodoContrato { get; set; }

    public int CntContratoIdTercero { get; set; }

    public int CntContratoIdTipoServicio { get; set; }

    public int CntContratoIdTipoContrato { get; set; }

    public int CntContratoIdTerceroServicio { get; set; }

    public int CntContratoIdSubtipoDocumento { get; set; }

    public int CntContratoIdDepartamentoSolicitud { get; set; }

    public int CntContratoIdUsuarioCoordinador { get; set; }

    public int CntContratoIdDocumentoAlquiler { get; set; }

    public int IdZona { get; set; }

    public string GenZonaZona { get; set; } = null!;

    public string? GenZonaZonaCodigo { get; set; }

    public double? GenZonaTiempoDesplazamiento { get; set; }

    public int GenZonaNivel { get; set; }

    public int GenZonaIdZona { get; set; }

    public string? GenZonaCodigoExterno { get; set; }

    public string? DocDocumentoOtDocumentoCodigo { get; set; }

    public int DocDocumentoOtDocumentoNumero { get; set; }

    public string DocDocumentoOtPrefijo { get; set; } = null!;

    public double DocDocumentoOtSubtotal { get; set; }

    public double DocDocumentoOtDescuento { get; set; }

    public double DocDocumentoOtIva { get; set; }

    public double DocDocumentoOtTotal { get; set; }

    public double DocDocumentoOtCosto { get; set; }

    public double DocDocumentoOtRentabilidad { get; set; }

    public double DocDocumentoOtTrm { get; set; }

    public DateTime DocDocumentoOtFechaFh { get; set; }

    public DateTime DocDocumentoOtFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOtFechaCierreFf { get; set; }

    public DateTime DocDocumentoOtFechaLimiteFh { get; set; }

    public int? DocDocumentoOtDocPrioridadDocumentoOrden { get; set; }

    public int DocDocumentoOtIdSubtipoDocumento { get; set; }

    public string DocDocumentoOtDocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocDocumentoOtDocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocDocumentoOtDocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocDocumentoOtDocSubtipoDocumentoConsecutivo { get; set; }

    public int DocDocumentoOtDocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoValUrgente { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocDocumentoOtDocSubtipoDocumentoCerrarSol { get; set; }

    public int DocDocumentoOtIdTerceroCliente { get; set; }

    public string DocDocumentoOtTerTerceroClienteTercero { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroClienteTerceroCodigo { get; set; }

    public string DocDocumentoOtTerTerceroClienteTerceroNit { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroClienteDireccion { get; set; }

    public string? DocDocumentoOtTerTerceroClienteContacto { get; set; }

    public string DocDocumentoOtTerTerceroClienteTelefono { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroClienteFax { get; set; }

    public string? DocDocumentoOtTerTerceroClienteEmail { get; set; }

    public string? DocDocumentoOtTerTerceroClienteWebsite { get; set; }

    public string? DocDocumentoOtTerTerceroClienteRepresentante { get; set; }

    public string? DocDocumentoOtTerTerceroClienteNotas { get; set; }

    public string DocDocumentoOtTerTerceroClienteTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoOtTerTerceroClienteEsCliente { get; set; }

    public bool DocDocumentoOtTerTerceroClienteEsProveedor { get; set; }

    public bool DocDocumentoOtTerTerceroClienteEsTransportador { get; set; }

    public bool DocDocumentoOtTerTerceroClienteEsFabricante { get; set; }

    public bool DocDocumentoOtTerTerceroClienteEsEmpresaPropia { get; set; }

    public string? DocDocumentoOtTerTerceroClienteClasificacion { get; set; }

    public int DocDocumentoOtTerTerceroClienteIdZona { get; set; }

    public int DocDocumentoOtTerTerceroClienteIdEstadoTercero { get; set; }

    public int DocDocumentoOtTerTerceroClienteIdNaturalezaTercero { get; set; }

    public bool DocDocumentoOtTerTerceroClienteEsProspecto { get; set; }

    public int DocDocumentoOtIdDocumento { get; set; }

    public string DocDocumentoOtDocDocumentoPadreDocumento { get; set; } = null!;

    public string? DocDocumentoOtDocDocumentoPadreDocumentoCodigo { get; set; }

    public int DocDocumentoOtDocDocumentoPadreDocumentoNumero { get; set; }

    public string DocDocumentoOtDocDocumentoPadrePrefijo { get; set; } = null!;

    public double DocDocumentoOtDocDocumentoPadreSubtotal { get; set; }

    public double DocDocumentoOtDocDocumentoPadreDescuento { get; set; }

    public double DocDocumentoOtDocDocumentoPadreIva { get; set; }

    public double DocDocumentoOtDocDocumentoPadreTotal { get; set; }

    public double DocDocumentoOtDocDocumentoPadreCosto { get; set; }

    public double DocDocumentoOtDocDocumentoPadreRentabilidad { get; set; }

    public double DocDocumentoOtDocDocumentoPadreTrm { get; set; }

    public DateTime DocDocumentoOtDocDocumentoPadreFechaFh { get; set; }

    public DateTime DocDocumentoOtDocDocumentoPadreFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOtDocDocumentoPadreFechaCierreFf { get; set; }

    public DateTime DocDocumentoOtDocDocumentoPadreFechaLimiteFh { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdSubtipoDocumento { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdTerceroCliente { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdDocumento { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdTerceroProveedor { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdPrioridadDocumento { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdMoneda { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdMotivoestado { get; set; }

    public double DocDocumentoOtDocDocumentoPadreSubtotalPlaneado { get; set; }

    public double DocDocumentoOtDocDocumentoPadreDescuentoPlaneado { get; set; }

    public double DocDocumentoOtDocDocumentoPadreIvaPlaneado { get; set; }

    public double DocDocumentoOtDocDocumentoPadreTotalPlaneado { get; set; }

    public double DocDocumentoOtDocDocumentoPadreCostoPlaneado { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdUsuarioAsignado { get; set; }

    public int DocDocumentoOtDocDocumentoPadreIdUsuarioEnUso { get; set; }

    public int DocDocumentoOtIdTerceroProveedor { get; set; }

    public string DocDocumentoOtTerTerceroProveedorTercero { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroProveedorTerceroCodigo { get; set; }

    public string DocDocumentoOtTerTerceroProveedorTerceroNit { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroProveedorDireccion { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorContacto { get; set; }

    public string DocDocumentoOtTerTerceroProveedorTelefono { get; set; } = null!;

    public string? DocDocumentoOtTerTerceroProveedorFax { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorEmail { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorWebsite { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorRepresentante { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorNotas { get; set; }

    public string DocDocumentoOtTerTerceroProveedorTerceroNombreCorto { get; set; } = null!;

    public bool DocDocumentoOtTerTerceroProveedorEsCliente { get; set; }

    public bool DocDocumentoOtTerTerceroProveedorEsProveedor { get; set; }

    public bool DocDocumentoOtTerTerceroProveedorEsTransportador { get; set; }

    public bool DocDocumentoOtTerTerceroProveedorEsFabricante { get; set; }

    public bool DocDocumentoOtTerTerceroProveedorEsEmpresaPropia { get; set; }

    public string? DocDocumentoOtTerTerceroProveedorClasificacion { get; set; }

    public int DocDocumentoOtTerTerceroProveedorIdZona { get; set; }

    public int DocDocumentoOtTerTerceroProveedorIdEstadoTercero { get; set; }

    public int DocDocumentoOtTerTerceroProveedorIdNaturalezaTercero { get; set; }

    public bool DocDocumentoOtTerTerceroProveedorEsProspecto { get; set; }

    public int DocDocumentoOtIdPrioridadDocumento { get; set; }

    public string DocDocumentoOtDocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocDocumentoOtDocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocDocumentoOtDocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocDocumentoOtDocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocDocumentoOtDocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int DocDocumentoOtIdMoneda { get; set; }

    public string DocDocumentoOtGenMonedaMoneda { get; set; } = null!;

    public string? DocDocumentoOtGenMonedaMonedaCodigo { get; set; }

    public string DocDocumentoOtGenMonedaAbreviatura { get; set; } = null!;

    public double DocDocumentoOtGenMonedaCambio { get; set; }

    public int DocDocumentoOtIdEstadoTipoDocumento { get; set; }

    public string DocDocumentoOtDocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocDocumentoOtDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocDocumentoOtDocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocDocumentoOtDocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocDocumentoOtDocEstadoTipoDocumentoOrden { get; set; }

    public bool DocDocumentoOtDocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocDocumentoOtDocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocDocumentoOtDocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocDocumentoOtDocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocDocumentoOtDocEstadoTipoDocumentoDescripcion { get; set; }

    public int DocDocumentoOtIdMotivoestado { get; set; }

    public string DocDocumentoOtDocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocDocumentoOtDocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocDocumentoOtDocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public double DocDocumentoOtSubtotalPlaneado { get; set; }

    public double DocDocumentoOtDescuentoPlaneado { get; set; }

    public double DocDocumentoOtIvaPlaneado { get; set; }

    public double DocDocumentoOtTotalPlaneado { get; set; }

    public double DocDocumentoOtCostoPlaneado { get; set; }

    public int DocDocumentoOtIdUsuarioAsignado { get; set; }

    public string DocDocumentoOtSegUsuarioAsignadoUsuario { get; set; } = null!;

    public string? DocDocumentoOtSegUsuarioAsignadoUsuarioCodigo { get; set; }

    public int? DocDocumentoOtSegUsuarioAsignadoIntentosFallidos { get; set; }

    public int? DocDocumentoOtSegUsuarioAsignadoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioAsignadoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioAsignadoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoOtSegUsuarioAsignadoClave { get; set; }

    public string? DocDocumentoOtSegUsuarioAsignadoNombre { get; set; }

    public string? DocDocumentoOtSegUsuarioAsignadoProfesion { get; set; }

    public string DocDocumentoOtSegUsuarioAsignadoEmail { get; set; } = null!;

    public string? DocDocumentoOtSegUsuarioAsignadoDireccion { get; set; }

    public string? DocDocumentoOtSegUsuarioAsignadoTelefono { get; set; }

    public decimal? DocDocumentoOtSegUsuarioAsignadoCostoHora { get; set; }

    public double? DocDocumentoOtSegUsuarioAsignadoPorcentajeComision { get; set; }

    public bool? DocDocumentoOtSegUsuarioAsignadoAccesoActivo { get; set; }

    public bool? DocDocumentoOtSegUsuarioAsignadoCambiarClave { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioAsignadoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoOtSegUsuarioAsignadoAplicaRecargo { get; set; }

    public bool DocDocumentoOtSegUsuarioAsignadoSexo { get; set; }

    public int DocDocumentoOtSegUsuarioAsignadoIdPerfil { get; set; }

    public int DocDocumentoOtSegUsuarioAsignadoIdCargo { get; set; }

    public int DocDocumentoOtSegUsuarioAsignadoIdGrupo { get; set; }

    public int DocDocumentoOtSegUsuarioAsignadoIdZona { get; set; }

    public string? DocDocumentoOtSegUsuarioAsignadoIdentificacion { get; set; }

    public int DocDocumentoOtSegUsuarioAsignadoIdUsuario { get; set; }

    public byte[]? DocDocumentoOtSegUsuarioAsignadoPreferencias { get; set; }

    public bool DocDocumentoOtSegUsuarioAsignadoHabilitado { get; set; }

    public int DocDocumentoOtIdUsuarioEnUso { get; set; }

    public string DocDocumentoOtSegUsuarioEnUsoUsuario { get; set; } = null!;

    public string? DocDocumentoOtSegUsuarioEnUsoUsuarioCodigo { get; set; }

    public int? DocDocumentoOtSegUsuarioEnUsoIntentosFallidos { get; set; }

    public int? DocDocumentoOtSegUsuarioEnUsoNumeroIngresos { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioEnUsoFechaUltimoIngresoFh { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioEnUsoFechaIntentoFallidoFh { get; set; }

    public string? DocDocumentoOtSegUsuarioEnUsoClave { get; set; }

    public string? DocDocumentoOtSegUsuarioEnUsoNombre { get; set; }

    public string? DocDocumentoOtSegUsuarioEnUsoProfesion { get; set; }

    public string DocDocumentoOtSegUsuarioEnUsoEmail { get; set; } = null!;

    public string? DocDocumentoOtSegUsuarioEnUsoDireccion { get; set; }

    public string? DocDocumentoOtSegUsuarioEnUsoTelefono { get; set; }

    public decimal? DocDocumentoOtSegUsuarioEnUsoCostoHora { get; set; }

    public double? DocDocumentoOtSegUsuarioEnUsoPorcentajeComision { get; set; }

    public bool? DocDocumentoOtSegUsuarioEnUsoAccesoActivo { get; set; }

    public bool? DocDocumentoOtSegUsuarioEnUsoCambiarClave { get; set; }

    public DateTime? DocDocumentoOtSegUsuarioEnUsoFechaUltimoCambioClaveFh { get; set; }

    public bool DocDocumentoOtSegUsuarioEnUsoAplicaRecargo { get; set; }

    public bool DocDocumentoOtSegUsuarioEnUsoSexo { get; set; }

    public int DocDocumentoOtSegUsuarioEnUsoIdPerfil { get; set; }

    public int DocDocumentoOtSegUsuarioEnUsoIdCargo { get; set; }

    public int DocDocumentoOtSegUsuarioEnUsoIdGrupo { get; set; }

    public int DocDocumentoOtSegUsuarioEnUsoIdZona { get; set; }

    public string? DocDocumentoOtSegUsuarioEnUsoIdentificacion { get; set; }

    public int DocDocumentoOtSegUsuarioEnUsoIdUsuario { get; set; }

    public byte[]? DocDocumentoOtSegUsuarioEnUsoPreferencias { get; set; }

    public bool DocDocumentoOtSegUsuarioEnUsoHabilitado { get; set; }

    public int? DocDocumentoOtTerTerceroClienteIdFormaPago { get; set; }

    public int? DocDocumentoOtTerTerceroClienteTiempoEntrega { get; set; }

    public string Multiempresa { get; set; } = null!;

    public int IdFamilia { get; set; }
}
