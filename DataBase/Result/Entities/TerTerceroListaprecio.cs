namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerTerceroListaprecio : TerTerceroListaprecioObject
{
    public virtual CatListaPrecio IdListaprecioNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
