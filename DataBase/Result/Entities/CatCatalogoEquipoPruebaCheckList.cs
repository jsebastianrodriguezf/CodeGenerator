namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoEquipoPruebaCheckList : CatCatalogoEquipoPruebaCheckListObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
}
