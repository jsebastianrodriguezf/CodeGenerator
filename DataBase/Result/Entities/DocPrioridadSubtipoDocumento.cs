namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocPrioridadSubtipoDocumento : DocPrioridadSubtipoDocumentoObject
{
    public virtual DocPrioridadDocumento IdPrioridadDocumentoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
}
