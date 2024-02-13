namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerTerceroUsuario : TerTerceroUsuarioObject
{
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
