namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntTiempoRespuestum : CntTiempoRespuestumObject
{
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual DocEstrategiaPrioridad IdEstrategiaPrioridadNavigation { get; set; } = null!;
    public virtual DocPrioridadDocumento IdPrioridadDocumentoNavigation { get; set; } = null!;
}
