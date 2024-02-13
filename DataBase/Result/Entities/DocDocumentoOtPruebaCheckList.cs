namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoOtPruebaCheckList : DocDocumentoOtPruebaCheckListObject
{
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
}
