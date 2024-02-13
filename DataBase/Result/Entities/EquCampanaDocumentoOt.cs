namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquCampanaDocumentoOt : EquCampanaDocumentoOtObject
{
    public virtual EquCampana IdCampanaNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
