namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatDetalleTempario : CatDetalleTemparioObject
{
    public virtual ICollection<CatSoporteActividad> CatSoporteActividads { get; set; } = new List<CatSoporteActividad>();
    public virtual ICollection<CatVersionEquipoDetalleTempario> CatVersionEquipoDetalleTemparios { get; set; } = new List<CatVersionEquipoDetalleTempario>();
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
    public virtual CatDetalleTempario IdDetalleTemparioPadreNavigation { get; set; } = null!;
    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
    public virtual ICollection<CatDetalleTempario> InverseIdDetalleTemparioPadreNavigation { get; set; } = new List<CatDetalleTempario>();
}
