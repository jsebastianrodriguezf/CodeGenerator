namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerTerceroSector : TerTerceroSectorObject
{
    public virtual TerSector IdSectorNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
