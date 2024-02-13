namespace SAMMAI.DataBase.Repository.Entities;

public partial class LicParametro : LicParametroObject
{
    public virtual ICollection<LicCatalogoParametro> LicCatalogoParametros { get; set; } = new List<LicCatalogoParametro>();
    public virtual ICollection<LicLicenciaParametro> LicLicenciaParametros { get; set; } = new List<LicLicenciaParametro>();
}
