namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocEstadoTipoDocumentoSubtipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EstadoTipoDocumentoSubtipoDocumento { get; set; } = null!;
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
    public int IdEstadoTipoDocumentoDestino { get; set; }
    public string DocEstadoTipoDocumentoDestinoEstadoTipoDocumento { get; set; } = null!;
    public string? DocEstadoTipoDocumentoDestinoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocEstadoTipoDocumentoDestinoAfectaIndicador { get; set; }
    public bool DocEstadoTipoDocumentoDestinoEditaDocumento { get; set; }
    public int DocEstadoTipoDocumentoDestinoOrden { get; set; }
    public bool DocEstadoTipoDocumentoDestinoPuedeRegresar { get; set; }
    public string DocEstadoTipoDocumentoDestinoColor { get; set; } = null!;
    public bool DocEstadoTipoDocumentoDestinoAfectaInventario { get; set; }
    public int DocEstadoTipoDocumentoDestinoIdTipoDocumento { get; set; }
    public string? DocEstadoTipoDocumentoDestinoDescripcion { get; set; }
    public bool DocEstadoTipoDocumentoDestinoObservacionesObligatorio { get; set; }
    public bool DocEstadoTipoDocumentoDestinoMotivoObligatorio { get; set; }
    public string SpEjecucionfinal { get; set; } = null!;
    public double TiempoDeEjecucion { get; set; }
    public string Multiempresa { get; set; } = null!;
}
