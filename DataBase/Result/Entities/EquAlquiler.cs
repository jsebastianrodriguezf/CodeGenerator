namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquAlquiler : EquAlquilerObject
{
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
