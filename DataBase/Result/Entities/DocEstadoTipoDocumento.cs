namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocEstadoTipoDocumento : DocEstadoTipoDocumentoObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();
    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();
    public virtual ICollection<DocEstadoTipoDocumentoPerfil> DocEstadoTipoDocumentoPerfils { get; set; } = new List<DocEstadoTipoDocumentoPerfil>();
    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoDestinoNavigations { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();
    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoNavigations { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();
    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdEstadoTipoDocumentoOrigenNavigations { get; set; } = new List<DocFlujoDocumento>();
    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdEstadoTipoDocumentoResultadoNavigations { get; set; } = new List<DocFlujoDocumento>();
    public virtual ICollection<DocMotivoestado> DocMotivoestados { get; set; } = new List<DocMotivoestado>();
    public virtual ICollection<GasGasto> GasGastos { get; set; } = new List<GasGasto>();
    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();
    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
    public virtual ICollection<SynPuntoIntegracionEstadoTipoDocumento> SynPuntoIntegracionEstadoTipoDocumentos { get; set; } = new List<SynPuntoIntegracionEstadoTipoDocumento>();
}
