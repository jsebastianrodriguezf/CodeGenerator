namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerContactoSucursal : TerContactoSucursalObject
{
    public virtual TerContacto IdContactoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
