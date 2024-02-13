namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocTarea : DocTareaObject
{
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
}
