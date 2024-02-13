namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenBodegaUsuario : GenBodegaUsuarioObject
{
    public virtual GenBodega IdBodegaNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
