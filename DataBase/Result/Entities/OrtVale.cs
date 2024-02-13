namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtVale : OrtValeObject
{
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
