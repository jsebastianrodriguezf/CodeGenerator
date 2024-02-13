namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocPrioridadDocumento : DocPrioridadDocumentoObject
{
    public virtual ICollection<CntTiempoRespuestum> CntTiempoRespuesta { get; set; } = new List<CntTiempoRespuestum>();
    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();
    public virtual ICollection<DocPrioridadSubtipoDocumento> DocPrioridadSubtipoDocumentos { get; set; } = new List<DocPrioridadSubtipoDocumento>();
    public virtual DocEstrategiaPrioridad IdEstrategiaPrioridadNavigation { get; set; } = null!;
    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
}
