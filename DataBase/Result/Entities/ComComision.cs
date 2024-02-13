namespace SAMMAI.DataBase.Repository.Entities;

public partial class ComComision : ComComisionObject
{
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual DocCondicion IdCondicionNavigation { get; set; } = null!;
    public virtual DocOpcionCondicion IdOpcionCondicionNavigation { get; set; } = null!;
    public virtual CatSubtipoCatalogo IdSubtipoCatalogoNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
}
