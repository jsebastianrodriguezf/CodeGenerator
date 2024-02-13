namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoTempario : CatCatalogoTemparioObject
{
    public virtual ICollection<CatCatalogoEquipoCatalogoTempario> CatCatalogoEquipoCatalogoTemparios { get; set; } = new List<CatCatalogoEquipoCatalogoTempario>();
    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();
    public virtual ICollection<CntConfigContrato> CntConfigContratos { get; set; } = new List<CntConfigContrato>();
    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();
    public virtual ICollection<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; } = new List<DocDocumentoCatalogoTempario>();
    public virtual ICollection<EquCampana> EquCampanas { get; set; } = new List<EquCampana>();
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
}
