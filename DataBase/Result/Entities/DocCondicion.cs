namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocCondicion : DocCondicionObject
{
    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();
    public virtual ICollection<DocDocumentoCotizacionCondicion> DocDocumentoCotizacionCondicions { get; set; } = new List<DocDocumentoCotizacionCondicion>();
    public virtual ICollection<DocOpcionCondicion> DocOpcionCondicions { get; set; } = new List<DocOpcionCondicion>();
}
