namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatSoporteActividad : CatSoporteActividadObject
{
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual CatDetalleTempario IdDetalleTemparioNavigation { get; set; } = null!;
}
