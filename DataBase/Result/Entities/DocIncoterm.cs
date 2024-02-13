namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocIncoterm : DocIncotermObject
{
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
}
