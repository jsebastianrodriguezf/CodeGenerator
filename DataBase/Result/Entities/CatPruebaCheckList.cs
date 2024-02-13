namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatPruebaCheckList : CatPruebaCheckListObject
{
    public virtual ICollection<CatCatalogoEquipoPruebaCheckList> CatCatalogoEquipoPruebaCheckLists { get; set; } = new List<CatCatalogoEquipoPruebaCheckList>();
    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();
    public virtual ICollection<CatPruebaCheckListAtributo> CatPruebaCheckListAtributos { get; set; } = new List<CatPruebaCheckListAtributo>();
    public virtual ICollection<DocDocumentoOtPruebaCheckList> DocDocumentoOtPruebaCheckLists { get; set; } = new List<DocDocumentoOtPruebaCheckList>();
}
