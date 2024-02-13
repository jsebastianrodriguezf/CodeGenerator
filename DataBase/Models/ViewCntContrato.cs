using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCntContrato
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Contrato { get; set; } = null!;

    public string? ContratoCodigo { get; set; }

    public string Numero { get; set; } = null!;

    public decimal? TotalContrato { get; set; }

    public decimal? Presupuesto { get; set; }

    public DateTime FechaInicioFf { get; set; }

    public DateTime? FechaFinFf { get; set; }

    public int? DiasCumplimiento { get; set; }

    public string? Condiciones { get; set; }

    public int IdPeriodoContrato { get; set; }

    public string CntPeriodoContratoPeriodoContrato { get; set; } = null!;

    public string? CntPeriodoContratoPeriodoContratoCodigo { get; set; }

    public int IdTercero { get; set; }

    public string TerTerceroTercero { get; set; } = null!;

    public string? TerTerceroTerceroCodigo { get; set; }

    public string TerTerceroTerceroNit { get; set; } = null!;

    public string? TerTerceroDireccion { get; set; }

    public string? TerTerceroContacto { get; set; }

    public string TerTerceroTelefono { get; set; } = null!;

    public string? TerTerceroFax { get; set; }

    public string? TerTerceroEmail { get; set; }

    public string? TerTerceroWebsite { get; set; }

    public string? TerTerceroRepresentante { get; set; }

    public string? TerTerceroNotas { get; set; }

    public string TerTerceroTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroEsCliente { get; set; }

    public bool TerTerceroEsProveedor { get; set; }

    public bool TerTerceroEsTransportador { get; set; }

    public bool TerTerceroEsFabricante { get; set; }

    public bool TerTerceroEsEmpresaPropia { get; set; }

    public string? TerTerceroClasificacion { get; set; }

    public int TerTerceroIdZona { get; set; }

    public int TerTerceroIdEstadoTercero { get; set; }

    public int TerTerceroIdNaturalezaTercero { get; set; }

    public bool TerTerceroEsProspecto { get; set; }

    public int IdTipoServicio { get; set; }

    public string GenTipoServicioTipoServicio { get; set; } = null!;

    public string? GenTipoServicioTipoServicioCodigo { get; set; }

    public bool? GenTipoServicioTieneGarantia { get; set; }

    public int? GenTipoServicioDiasGarantia { get; set; }

    public int IdTipoContrato { get; set; }

    public string CntTipoContratoTipoContrato { get; set; } = null!;

    public string? CntTipoContratoTipoContratoCodigo { get; set; }

    public int IdTerceroServicio { get; set; }

    public string TerTerceroServicioTercero { get; set; } = null!;

    public string? TerTerceroServicioTerceroCodigo { get; set; }

    public string TerTerceroServicioTerceroNit { get; set; } = null!;

    public string? TerTerceroServicioDireccion { get; set; }

    public string? TerTerceroServicioContacto { get; set; }

    public string TerTerceroServicioTelefono { get; set; } = null!;

    public string? TerTerceroServicioFax { get; set; }

    public string? TerTerceroServicioEmail { get; set; }

    public string? TerTerceroServicioWebsite { get; set; }

    public string? TerTerceroServicioRepresentante { get; set; }

    public string? TerTerceroServicioNotas { get; set; }

    public string TerTerceroServicioTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroServicioEsCliente { get; set; }

    public bool TerTerceroServicioEsProveedor { get; set; }

    public bool TerTerceroServicioEsTransportador { get; set; }

    public bool TerTerceroServicioEsFabricante { get; set; }

    public bool TerTerceroServicioEsEmpresaPropia { get; set; }

    public string? TerTerceroServicioClasificacion { get; set; }

    public int TerTerceroServicioIdZona { get; set; }

    public int TerTerceroServicioIdEstadoTercero { get; set; }

    public int TerTerceroServicioIdNaturalezaTercero { get; set; }

    public bool TerTerceroServicioEsProspecto { get; set; }

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

    public int IdDepartamentoSolicitud { get; set; }

    public string OrtDepartamentoSolicitudDepartamentoSolicitud { get; set; } = null!;

    public string? OrtDepartamentoSolicitudDepartamentoSolicitudCodigo { get; set; }

    public bool OrtDepartamentoSolicitudRecibeSolicitudes { get; set; }

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

    public int IdDocumentoAlquiler { get; set; }

    public string DocDocumentoAlquilerDocumentoAlquiler { get; set; } = null!;

    public DateTime? DocDocumentoAlquilerFechaFinFf { get; set; }

    public bool DocDocumentoAlquilerMesVencido { get; set; }

    public string? DocDocumentoAlquilerObservaciones { get; set; }

    public bool DocDocumentoAlquilerEjecutaDevolucion { get; set; }

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

    public int DocDocumentoAlquilerIdSubtipoDocumento { get; set; }

    public int DocDocumentoAlquilerIdTerceroCliente { get; set; }

    public int DocDocumentoAlquilerIdDocumento { get; set; }

    public int DocDocumentoAlquilerIdTerceroProveedor { get; set; }

    public int DocDocumentoAlquilerIdPrioridadDocumento { get; set; }

    public int DocDocumentoAlquilerIdMoneda { get; set; }

    public int DocDocumentoAlquilerIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoAlquilerIdMotivoestado { get; set; }

    public double DocDocumentoAlquilerSubtotalPlaneado { get; set; }

    public double DocDocumentoAlquilerDescuentoPlaneado { get; set; }

    public double DocDocumentoAlquilerIvaPlaneado { get; set; }

    public double DocDocumentoAlquilerTotalPlaneado { get; set; }

    public double DocDocumentoAlquilerCostoPlaneado { get; set; }

    public int DocDocumentoAlquilerIdUsuarioAsignado { get; set; }

    public int DocDocumentoAlquilerIdUsuarioEnUso { get; set; }

    public int IdEstadoTipoDocumentoInicial { get; set; }

    public string DocEstadoTipoDocumentoInicialEstadoTipoDocumento { get; set; } = null!;

    public string? DocEstadoTipoDocumentoInicialEstadoTipoDocumentoCodigo { get; set; }

    public bool DocEstadoTipoDocumentoInicialAfectaIndicador { get; set; }

    public bool DocEstadoTipoDocumentoInicialEditaDocumento { get; set; }

    public int DocEstadoTipoDocumentoInicialOrden { get; set; }

    public bool DocEstadoTipoDocumentoInicialPuedeRegresar { get; set; }

    public string DocEstadoTipoDocumentoInicialColor { get; set; } = null!;

    public bool DocEstadoTipoDocumentoInicialAfectaInventario { get; set; }

    public int DocEstadoTipoDocumentoInicialIdTipoDocumento { get; set; }

    public string? DocEstadoTipoDocumentoInicialDescripcion { get; set; }

    public int IdSubtipoDocumentoSolicitud { get; set; }

    public string DocSubtipoDocumentoSolicitudSubtipoDocumento { get; set; } = null!;

    public string? DocSubtipoDocumentoSolicitudSubtipoDocumentoCodigo { get; set; }

    public string DocSubtipoDocumentoSolicitudPrefijo { get; set; } = null!;

    public int DocSubtipoDocumentoSolicitudConsecutivo { get; set; }

    public int DocSubtipoDocumentoSolicitudIdTipoDocumento { get; set; }

    public bool DocSubtipoDocumentoSolicitudProgramarPlaneadas { get; set; }

    public bool DocSubtipoDocumentoSolicitudCargarSolicitante { get; set; }

    public bool DocSubtipoDocumentoSolicitudVerCentroCosto { get; set; }

    public bool DocSubtipoDocumentoSolicitudVerIncoterm { get; set; }

    public bool DocSubtipoDocumentoSolicitudValUrgente { get; set; }

    public bool DocSubtipoDocumentoSolicitudBloquearDespacho { get; set; }

    public bool DocSubtipoDocumentoSolicitudCerrarSol { get; set; }

    public bool DocSubtipoDocumentoSolicitudEjecutaDevolucion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
