namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocFlujoDocumento : DocFlujoDocumentoObject
{
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoOrigenNavigation { get; set; } = null!;
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoResultadoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoDestinoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoOrigenNavigation { get; set; } = null!;
}
