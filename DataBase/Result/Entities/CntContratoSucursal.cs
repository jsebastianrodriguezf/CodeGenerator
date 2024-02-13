namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoSucursal : CntContratoSucursalObject
{
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
