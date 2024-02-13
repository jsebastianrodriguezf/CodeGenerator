namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatPruebaCheckListAtributo : CatPruebaCheckListAtributoObject
{
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
}
