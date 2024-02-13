namespace SAMMAI.Transverse.Models.Objects;

public class DisEventoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Evento { get; set; } = null!;
    public string? EventoCodigo { get; set; }
    public DateTime FechaHoraInicioFf { get; set; }
    public DateTime DuracionHh { get; set; }
    public bool AfectaProduccion { get; set; }
    public string? Notas { get; set; }
    public int IdEquipo { get; set; }
    public int IdMotivoEvento { get; set; }
    public int IdUsuario { get; set; }
    public int IdEstadoEquipo { get; set; }
    public int IdFalla { get; set; }
    public int IdFallaCausa { get; set; }
    public int IdMetodoDeteccion { get; set; }
    public DateTime FechaHoraEstimadaFh { get; set; }
    public int EventoTipo { get; set; }
    public bool AfectaCliente { get; set; }
    public int IdEstadoEvento { get; set; }
    public string? Codigo { get; set; }
}
