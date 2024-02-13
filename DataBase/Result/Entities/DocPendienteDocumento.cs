namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocPendienteDocumento : DocPendienteDocumentoObject
{
    public virtual ICollection<DocPendienteDocumentoDocItemDocumento> DocPendienteDocumentoDocItemDocumentos { get; set; } = new List<DocPendienteDocumentoDocItemDocumento>();
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
}
