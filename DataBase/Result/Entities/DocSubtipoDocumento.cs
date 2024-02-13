namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocSubtipoDocumento : DocSubtipoDocumentoObject
{
    public virtual ICollection<CntContrato> CntContratoIdSubtipoDocumentoNavigations { get; set; } = new List<CntContrato>();
    public virtual ICollection<CntContrato> CntContratoIdSubtipoDocumentoSolicitudNavigations { get; set; } = new List<CntContrato>();
    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();
    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentos { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();
    public virtual ICollection<DocEvaluacion> DocEvaluacions { get; set; } = new List<DocEvaluacion>();
    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdSubtipoDocumentoDestinoNavigations { get; set; } = new List<DocFlujoDocumento>();
    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdSubtipoDocumentoOrigenNavigations { get; set; } = new List<DocFlujoDocumento>();
    public virtual ICollection<DocPrioridadSubtipoDocumento> DocPrioridadSubtipoDocumentos { get; set; } = new List<DocPrioridadSubtipoDocumento>();
    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();
    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();
    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
    public virtual ICollection<SegPerfilSubtipoDocumento> SegPerfilSubtipoDocumentos { get; set; } = new List<SegPerfilSubtipoDocumento>();
}
