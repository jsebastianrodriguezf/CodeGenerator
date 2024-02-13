namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenFamilium : GenFamiliumObject
{
    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<EquFamiliaFalla> EquFamiliaFallas { get; set; } = new List<EquFamiliaFalla>();
    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;
    public virtual ICollection<GenFamilium> InverseIdFamiliaNavigation { get; set; } = new List<GenFamilium>();
}
