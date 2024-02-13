namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoOtCentroCosto : DocDocumentoOtCentroCostoObject
{
    public virtual DocCentroCosto IdCentroCostoNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
