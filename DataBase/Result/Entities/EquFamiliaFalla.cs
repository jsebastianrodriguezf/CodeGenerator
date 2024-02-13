namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquFamiliaFalla : EquFamiliaFallaObject
{
    public virtual EquFalla IdFallaNavigation { get; set; } = null!;
    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;
}
