namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoTipoServicio : CntContratoTipoServicioObject
{
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual CatListaPrecio IdListaPrecioNavigation { get; set; } = null!;
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
}
