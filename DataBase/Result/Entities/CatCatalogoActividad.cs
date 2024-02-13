namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoActividad : CatCatalogoActividadObject
{
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
    public virtual ICollection<SegCargoActividad> SegCargoActividads { get; set; } = new List<SegCargoActividad>();
}
