namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisEventoCatalogo : DisEventoCatalogoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
}
