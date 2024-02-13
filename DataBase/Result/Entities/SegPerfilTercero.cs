namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfilTercero : SegPerfilTerceroObject
{
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
