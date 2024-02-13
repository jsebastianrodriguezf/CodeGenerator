namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocEstadoTipoDocumentoSubtipoDocumento : DocEstadoTipoDocumentoSubtipoDocumentoObject
{
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoDestinoNavigation { get; set; } = null!;
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
}
