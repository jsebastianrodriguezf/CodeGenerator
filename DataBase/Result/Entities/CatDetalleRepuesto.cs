namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatDetalleRepuesto : CatDetalleRepuestoObject
{
    public virtual CatCatalogoRepuesto IdCatalogoRepuestoHijoNavigation { get; set; } = null!;
    public virtual CatCatalogoRepuesto IdCatalogoRepuestoNavigation { get; set; } = null!;
}
