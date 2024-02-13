namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenNotificacion : GenNotificacionObject
{
    public virtual GenTipoNotificacion IdTipoNotificacionNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioDestinoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioOrigenNavigation { get; set; } = null!;
}
