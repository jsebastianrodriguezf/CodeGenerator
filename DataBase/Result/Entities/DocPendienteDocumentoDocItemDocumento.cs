namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocPendienteDocumentoDocItemDocumento : DocPendienteDocumentoDocItemDocumentoObject
{
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
    public virtual DocPendienteDocumento IdPendienteDocumentoNavigation { get; set; } = null!;
}
