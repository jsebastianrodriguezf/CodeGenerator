namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocCentroCosto : DocCentroCostoObject
{
    public virtual ICollection<DocDocumentoOtCentroCosto> DocDocumentoOtCentroCostos { get; set; } = new List<DocDocumentoOtCentroCosto>();
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
}
