namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntVisitaFija : CntVisitaFijaObject
{
    public virtual ICollection<CntCorrimientoVisitaFija> CntCorrimientoVisitaFijas { get; set; } = new List<CntCorrimientoVisitaFija>();
    public virtual ICollection<CntVisitaFijaCatalogo> CntVisitaFijaCatalogos { get; set; } = new List<CntVisitaFijaCatalogo>();
    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
    public virtual CntConfigContrato? IdConfigContratoNavigation { get; set; }
    public virtual CntContratoDetalleVisitum IdContratoDetalleVisitaNavigation { get; set; } = null!;
    public virtual CntContratoEquipo IdContratoEquipoNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
