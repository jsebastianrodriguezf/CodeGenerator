namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynPuntoIntegracion : SynPuntoIntegracionObject
{
    public virtual ICollection<GenAccionNotificacion> GenAccionNotificacions { get; set; } = new List<GenAccionNotificacion>();
    public virtual SynPuntoIntegracion? IdPuntoIntegracionNavigation { get; set; }
    public virtual SynSistemaIntegrar? IdSistemaIntegrarNavigation { get; set; }
    public virtual ICollection<SynPuntoIntegracion> InverseIdPuntoIntegracionNavigation { get; set; } = new List<SynPuntoIntegracion>();
    public virtual ICollection<SegRegistroIntegracion> SegRegistroIntegracions { get; set; } = new List<SegRegistroIntegracion>();
    public virtual ICollection<SynCampoIntegracion> SynCampoIntegracions { get; set; } = new List<SynCampoIntegracion>();
    public virtual ICollection<SynPuntoIntegracionEstadoTipoDocumento> SynPuntoIntegracionEstadoTipoDocumentos { get; set; } = new List<SynPuntoIntegracionEstadoTipoDocumento>();
    public virtual ICollection<SynPuntoIntegracionTabla> SynPuntoIntegracionTablas { get; set; } = new List<SynPuntoIntegracionTabla>();
}
