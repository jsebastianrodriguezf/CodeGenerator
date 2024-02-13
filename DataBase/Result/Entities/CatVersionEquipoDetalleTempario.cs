namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatVersionEquipoDetalleTempario : CatVersionEquipoDetalleTemparioObject
{
    public virtual CatDetalleTempario IdDetalleTemparioNavigation { get; set; } = null!;
    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
}
