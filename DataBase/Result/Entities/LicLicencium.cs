namespace SAMMAI.DataBase.Repository.Entities;

public partial class LicLicencium : LicLicenciumObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual ICollection<LicLicenciaParametro> LicLicenciaParametros { get; set; } = new List<LicLicenciaParametro>();
}
