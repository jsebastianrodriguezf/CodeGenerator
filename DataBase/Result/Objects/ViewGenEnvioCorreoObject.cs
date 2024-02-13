namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenEnvioCorreoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EnvioCorreo { get; set; } = null!;
    public string? EnvioCorreoCodigo { get; set; }
    public int Estrategia { get; set; }
    public string Tabla { get; set; } = null!;
    public int IdReporte { get; set; }
    public string RepReporteReporte { get; set; } = null!;
    public string? RepReporteReporteCodigo { get; set; }
    public int RepReporteIdFuncionalidad { get; set; }
    public bool RepReporteEsFormato { get; set; }
    public bool RepReporteTieneGraficos { get; set; }
    public string RepReporteCabecera { get; set; } = null!;
    public int RepReporteOrden { get; set; }
    public bool RepReporteBasica { get; set; }
    public string? CorreoAdicional { get; set; }
    public string? PlantillaAdjunto { get; set; }
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
    public int CantidadMensajes { get; set; }
    public int TiempoPorMensajes { get; set; }
    public int CantidadReintento { get; set; }
    public int? IdRemitenteCorreo { get; set; }
    public string GenRemitenteCorreoRemitenteCorreo { get; set; } = null!;
    public string? GenRemitenteCorreoRemitenteCorreoCodigo { get; set; }
    public string? GenRemitenteCorreoServidor { get; set; }
    public bool? GenRemitenteCorreoCertificado { get; set; }
    public string? GenRemitenteCorreoPuerto { get; set; }
    public string? GenRemitenteCorreoCredenciales { get; set; }
    public string? GenRemitenteCorreoCuentaCertificado { get; set; }
    public string? GenRemitenteCorreoArchivoCertificado { get; set; }
    public bool? GenRemitenteCorreoEsGsuite { get; set; }
    public int? AdjuntarArchivo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
