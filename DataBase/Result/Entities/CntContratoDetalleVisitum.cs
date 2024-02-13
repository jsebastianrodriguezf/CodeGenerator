namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoDetalleVisitum : CntContratoDetalleVisitumObject
{
    public virtual ICollection<CntContratoEquipo> CntContratoEquipos { get; set; } = new List<CntContratoEquipo>();
    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
}
