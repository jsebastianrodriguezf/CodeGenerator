namespace SAMMAI.Transverse.Models.Objects;

public class GenNotificacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Notificacion { get; set; } = null!;
    public string? NotificacionCodigo { get; set; }
    public int IdTipoNotificacion { get; set; }
    public int IdUsuarioOrigen { get; set; }
    public int IdUsuarioDestino { get; set; }
    public string Datos { get; set; } = null!;
}
