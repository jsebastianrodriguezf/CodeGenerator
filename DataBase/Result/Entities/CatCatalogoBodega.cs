namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoBodega : CatCatalogoBodegaObject
{
    public virtual GenBodega IdBodegaNavigation { get; set; } = null!;
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
}
