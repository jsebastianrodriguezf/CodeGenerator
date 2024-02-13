namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatTipoCatalogoListaPrecio : CatTipoCatalogoListaPrecioObject
{
    public virtual CatListaPrecio IdListaPrecioNavigation { get; set; } = null!;
    public virtual CatTipoCatalogo IdTipoCatalogoNavigation { get; set; } = null!;
}
