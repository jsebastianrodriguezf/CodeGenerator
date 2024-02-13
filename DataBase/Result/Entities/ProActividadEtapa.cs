namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProActividadEtapa : ProActividadEtapaObject
{
    public virtual ProActividad IdActividadNavigation { get; set; } = null!;
    public virtual ProEtapa IdEtapaNavigation { get; set; } = null!;
}
