namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoListaPrecio : CatCatalogoListaPrecioObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual CatListaPrecio IdListaPrecioNavigation { get; set; } = null!;
}
