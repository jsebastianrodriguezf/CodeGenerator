namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntConfigContrato : CntConfigContratoObject
{
    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();
    public virtual CatCatalogoTempario? IdCatalogoTemparioNavigation { get; set; }
    public virtual CntContratoEquipo? IdContratoEquipoNavigation { get; set; }
    public virtual TerTercero? IdTerceroProveedorNavigation { get; set; }
}
