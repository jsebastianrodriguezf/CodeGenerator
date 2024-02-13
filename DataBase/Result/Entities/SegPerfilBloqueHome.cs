namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfilBloqueHome : SegPerfilBloqueHomeObject
{
    public virtual GuiBloqueHome IdBloqueHomeNavigation { get; set; } = null!;
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
