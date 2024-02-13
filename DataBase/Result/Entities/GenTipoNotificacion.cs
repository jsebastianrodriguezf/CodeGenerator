namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenTipoNotificacion : GenTipoNotificacionObject
{
    public virtual ICollection<GenAccionNotificacion> GenAccionNotificacions { get; set; } = new List<GenAccionNotificacion>();
    public virtual ICollection<GenNotificacion> GenNotificacions { get; set; } = new List<GenNotificacion>();
}
