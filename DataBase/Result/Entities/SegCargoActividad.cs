namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegCargoActividad : SegCargoActividadObject
{
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual CatCatalogoActividad IdCatalogoActividadNavigation { get; set; } = null!;
}
