namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoContacto : DocDocumentoContactoObject
{
    public virtual TerContacto IdContactoNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
}
