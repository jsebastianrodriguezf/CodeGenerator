namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquTipoTrazabilidad : EquTipoTrazabilidadObject
{
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
}
