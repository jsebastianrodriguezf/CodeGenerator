namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocMotivoestado : DocMotivoestadoObject
{
    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();
    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
}
