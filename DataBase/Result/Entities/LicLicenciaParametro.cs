namespace SAMMAI.DataBase.Repository.Entities;

public partial class LicLicenciaParametro : LicLicenciaParametroObject
{
    public virtual LicLicencium IdLicenciaNavigation { get; set; } = null!;
    public virtual LicParametro IdParametroNavigation { get; set; } = null!;
}
