namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquCicloHorometro : EquCicloHorometroObject
{
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
}
