namespace SAMMAI.DataBase.Repository.Entities;

public partial class LicCatalogoParametro : LicCatalogoParametroObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual LicParametro IdParametroNavigation { get; set; } = null!;
}
