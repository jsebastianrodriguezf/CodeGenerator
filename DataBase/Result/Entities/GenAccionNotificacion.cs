namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenAccionNotificacion : GenAccionNotificacionObject
{
    public virtual SynPuntoIntegracion IdPuntoIntegracionNavigation { get; set; } = null!;
    public virtual GenTipoNotificacion IdTipoNotificacionNavigation { get; set; } = null!;
}
