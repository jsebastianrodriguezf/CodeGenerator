namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerSector : TerSectorObject
{
    public virtual ICollection<TerTerceroSector> TerTerceroSectors { get; set; } = new List<TerTerceroSector>();
}
