namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocEstadoTipoDocumentoPerfilObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EstadoTipoDocumentoPerfil { get; set; } = null!;
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
    public int IdPerfil { get; set; }
    public string SegPerfilPerfil { get; set; } = null!;
    public string? SegPerfilPerfilCodigo { get; set; }
    public string? SegPerfilDescripcion { get; set; }
    public bool? SegPerfilMostrarBotones { get; set; }
    public string Multiempresa { get; set; } = null!;
}
