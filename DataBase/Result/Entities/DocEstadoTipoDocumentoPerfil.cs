namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocEstadoTipoDocumentoPerfil : DocEstadoTipoDocumentoPerfilObject
{
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
