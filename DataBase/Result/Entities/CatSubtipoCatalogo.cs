namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatSubtipoCatalogo : CatSubtipoCatalogoObject
{
    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();
    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();
    public virtual CatTipoCatalogo IdTipoCatalogoNavigation { get; set; } = null!;
}
