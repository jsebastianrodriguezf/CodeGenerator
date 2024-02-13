namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntCorrimientoVisitaFija : CntCorrimientoVisitaFijaObject
{
    public virtual CntVisitaFija IdVisitaFijaNavigation { get; set; } = null!;
}
