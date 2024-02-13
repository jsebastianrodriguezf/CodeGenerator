namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerSucursalUsuario : TerSucursalUsuarioObject
{
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
