namespace SAMMAI.Transverse.Models.Objects;

public class AlqTarifaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Tarifa { get; set; } = null!;
    public string? TarifaCodigo { get; set; }
    public int IdItemDocumento { get; set; }
    public int IdDetalleAlquiler { get; set; }
    public int IdTipoTarifa { get; set; }
    public double HorasIncluidas { get; set; }
    public int CantidadIncluida { get; set; }
}
