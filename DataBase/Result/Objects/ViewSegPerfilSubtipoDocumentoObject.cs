namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegPerfilSubtipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PerfilSubtipoDocumento { get; set; } = null!;
    public int IdPerfil { get; set; }
    public string SegPerfilPerfil { get; set; } = null!;
    public string? SegPerfilPerfilCodigo { get; set; }
    public string? SegPerfilDescripcion { get; set; }
    public bool? SegPerfilMostrarBotones { get; set; }
    public bool? SegPerfilParaCliente { get; set; }
    public bool? SegPerfilParaProveedor { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
