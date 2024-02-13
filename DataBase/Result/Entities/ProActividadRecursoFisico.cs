namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProActividadRecursoFisico : ProActividadRecursoFisicoObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProRecursoFisico IdRecursoFisicoNavigation { get; set; } = null!;
}
