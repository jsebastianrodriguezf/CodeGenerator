namespace SAMMAI.Transverse.Models.Objects;

public class ViewSynPuntoIntegracionEstadoTipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PuntoIntegracionEstadoTipoDocumento { get; set; } = null!;
    public int? IdPuntoIntegracion { get; set; }
    public string SynPuntoIntegracionPuntoIntegracion { get; set; } = null!;
    public string? SynPuntoIntegracionPuntoIntegracionCodigo { get; set; }
    public string? SynPuntoIntegracionTablaLocal { get; set; }
    public string? SynPuntoIntegracionCondicion { get; set; }
    public string? SynPuntoIntegracionUrlConsumir { get; set; }
    public int? SynPuntoIntegracionIdPuntoIntegracion { get; set; }
    public int? SynPuntoIntegracionIdSistemaIntegrar { get; set; }
    public string? SynPuntoIntegracionMetodo { get; set; }
    public int? IdEstadoTipoDocumento { get; set; }
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
    public int? IdRolEstado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
