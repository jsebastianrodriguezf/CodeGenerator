namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoRepuesto : CatCatalogoRepuestoObject
{
    public virtual ICollection<CatDetalleRepuesto> CatDetalleRepuestoIdCatalogoRepuestoHijoNavigations { get; set; } = new List<CatDetalleRepuesto>();
    public virtual ICollection<CatDetalleRepuesto> CatDetalleRepuestoIdCatalogoRepuestoNavigations { get; set; } = new List<CatDetalleRepuesto>();
    public virtual ICollection<CatReemplazo> CatReemplazoIdCatalogoRepuesto1Navigations { get; set; } = new List<CatReemplazo>();
    public virtual ICollection<CatReemplazo> CatReemplazoIdCatalogoRepuestoNavigations { get; set; } = new List<CatReemplazo>();
    public virtual CatMarca IdMarcaNavigation { get; set; } = null!;
}
