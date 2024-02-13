namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoEstadoTipoDocumento : DocDocumentoEstadoTipoDocumentoObject
{
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual DocMotivoestado IdMotivoestadoNavigation { get; set; } = null!;
}
