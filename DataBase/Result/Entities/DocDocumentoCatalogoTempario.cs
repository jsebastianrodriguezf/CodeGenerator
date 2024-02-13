namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoCatalogoTempario : DocDocumentoCatalogoTemparioObject
{
    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
}
