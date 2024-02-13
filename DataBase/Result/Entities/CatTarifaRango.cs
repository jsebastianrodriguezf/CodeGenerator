namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatTarifaRango : CatTarifaRangoObject
{
    public virtual CatTarifa IdTarifaNavigation { get; set; } = null!;
}
