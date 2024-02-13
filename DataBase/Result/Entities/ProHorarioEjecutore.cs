namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProHorarioEjecutore : ProHorarioEjecutoreObject
{
    public virtual ICollection<ProEjecutore> ProEjecutores { get; set; } = new List<ProEjecutore>();
}
