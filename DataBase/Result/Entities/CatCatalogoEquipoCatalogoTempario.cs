namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoEquipoCatalogoTempario : CatCatalogoEquipoCatalogoTemparioObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
}
