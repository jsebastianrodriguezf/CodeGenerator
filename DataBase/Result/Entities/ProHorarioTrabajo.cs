namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProHorarioTrabajo : ProHorarioTrabajoObject
{
    public virtual ICollection<ProEjecutore> ProEjecutores { get; set; } = new List<ProEjecutore>();
}
