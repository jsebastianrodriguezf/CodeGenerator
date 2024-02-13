namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProActividadEjecutor : ProActividadEjecutorObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
}
