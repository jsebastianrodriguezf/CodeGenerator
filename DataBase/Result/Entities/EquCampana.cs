namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquCampana : EquCampanaObject
{
    public virtual ICollection<EquCampanaDocumentoOt> EquCampanaDocumentoOts { get; set; } = new List<EquCampanaDocumentoOt>();
    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
