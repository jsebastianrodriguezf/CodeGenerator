namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocTipoDocumento : DocTipoDocumentoObject
{
    public virtual ICollection<DocEstadoTipoDocumento> DocEstadoTipoDocumentos { get; set; } = new List<DocEstadoTipoDocumento>();
    public virtual ICollection<DocPendienteDocumento> DocPendienteDocumentos { get; set; } = new List<DocPendienteDocumento>();
    public virtual ICollection<DocPrioridadDocumento> DocPrioridadDocumentos { get; set; } = new List<DocPrioridadDocumento>();
    public virtual ICollection<DocSubtipoDocumento> DocSubtipoDocumentos { get; set; } = new List<DocSubtipoDocumento>();
}
