namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoAtributo : DocDocumentoAtributoObject
{
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual EquOpcionAtributo IdOpcionAtributoNavigation { get; set; } = null!;
}
