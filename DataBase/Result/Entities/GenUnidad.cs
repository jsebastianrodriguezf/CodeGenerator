namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenUnidad : GenUnidadObject
{
    public virtual ICollection<CatAtributo> CatAtributos { get; set; } = new List<CatAtributo>();
    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();
}
