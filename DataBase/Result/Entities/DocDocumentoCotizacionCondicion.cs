namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoCotizacionCondicion : DocDocumentoCotizacionCondicionObject
{
    public virtual DocCondicion IdCondicionNavigation { get; set; } = null!;
    public virtual DocDocumentoCotizacion IdDocumentoCotizacionNavigation { get; set; } = null!;
    public virtual DocOpcionCondicion IdOpcionCondicionNavigation { get; set; } = null!;
}
