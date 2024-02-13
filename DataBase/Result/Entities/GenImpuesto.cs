namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenImpuesto : GenImpuestoObject
{
    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();
}
