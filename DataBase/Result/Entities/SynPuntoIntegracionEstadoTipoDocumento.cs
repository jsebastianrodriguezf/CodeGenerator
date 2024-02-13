namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynPuntoIntegracionEstadoTipoDocumento : SynPuntoIntegracionEstadoTipoDocumentoObject
{
    public virtual DocEstadoTipoDocumento? IdEstadoTipoDocumentoNavigation { get; set; }
    public virtual SynPuntoIntegracion? IdPuntoIntegracionNavigation { get; set; }
}
