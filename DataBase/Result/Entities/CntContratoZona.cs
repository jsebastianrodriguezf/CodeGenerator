namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoZona : CntContratoZonaObject
{
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
}
