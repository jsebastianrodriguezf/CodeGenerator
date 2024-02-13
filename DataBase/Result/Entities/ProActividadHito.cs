namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProActividadHito : ProActividadHitoObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProHito IdHitoNavigation { get; set; } = null!;
}
