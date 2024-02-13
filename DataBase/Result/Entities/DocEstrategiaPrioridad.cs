namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocEstrategiaPrioridad : DocEstrategiaPrioridadObject
{
    public virtual ICollection<CntTiempoRespuestum> CntTiempoRespuesta { get; set; } = new List<CntTiempoRespuestum>();
    public virtual ICollection<DocPrioridadDocumento> DocPrioridadDocumentos { get; set; } = new List<DocPrioridadDocumento>();
}
