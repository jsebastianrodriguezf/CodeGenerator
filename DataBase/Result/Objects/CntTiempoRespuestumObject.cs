namespace SAMMAI.Transverse.Models.Objects;

public class CntTiempoRespuestumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TiempoRespuesta { get; set; } = null!;
    public string? TiempoRespuestaCodigo { get; set; }
    public int TiempoLimite { get; set; }
    public int IdContrato { get; set; }
    public int IdPrioridadDocumento { get; set; }
    public int IdEstrategiaPrioridad { get; set; }
}
