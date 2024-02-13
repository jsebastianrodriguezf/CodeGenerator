namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntVisitaFijaCatalogo : CntVisitaFijaCatalogoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual CntVisitaFija IdVisitaFijaNavigation { get; set; } = null!;
}
