namespace SAMMAI.Transverse.Models.Objects;

public class AlqHistoricoAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string HistoricoAlquiler { get; set; } = null!;
    public string? HistoricoAlquilerCodigo { get; set; }
    public DateTime FechaEstado { get; set; }
    public int? IdEquipo { get; set; }
    public int? IdEstadoEquipo { get; set; }
    public int? IdDocumento { get; set; }
}
