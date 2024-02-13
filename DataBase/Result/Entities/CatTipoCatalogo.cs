namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatTipoCatalogo : CatTipoCatalogoObject
{
    public virtual ICollection<CatSubtipoCatalogo> CatSubtipoCatalogos { get; set; } = new List<CatSubtipoCatalogo>();
    public virtual ICollection<CatTipoCatalogoListaPrecio> CatTipoCatalogoListaPrecios { get; set; } = new List<CatTipoCatalogoListaPrecio>();
}
