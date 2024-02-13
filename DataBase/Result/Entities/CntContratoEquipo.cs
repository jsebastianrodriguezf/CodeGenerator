namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoEquipo : CntContratoEquipoObject
{
    public virtual ICollection<CntConfigContrato> CntConfigContratos { get; set; } = new List<CntConfigContrato>();
    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();
    public virtual CntContratoDetalleVisitum IdContratoDetalleVisitaNavigation { get; set; } = null!;
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
}
