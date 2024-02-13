namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerSucursalListaprecio : TerSucursalListaprecioObject
{
    public virtual CatListaPrecio IdListaprecioNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
