namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfilSubtipoDocumento : SegPerfilSubtipoDocumentoObject
{
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
}
