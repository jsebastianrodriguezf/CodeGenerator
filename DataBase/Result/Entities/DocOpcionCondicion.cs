namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocOpcionCondicion : DocOpcionCondicionObject
{
    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();
    public virtual ICollection<DocDocumentoCotizacionCondicion> DocDocumentoCotizacionCondicions { get; set; } = new List<DocDocumentoCotizacionCondicion>();
    public virtual DocCondicion IdCondicionNavigation { get; set; } = null!;
}
