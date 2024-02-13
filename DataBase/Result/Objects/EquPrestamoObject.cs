namespace SAMMAI.Transverse.Models.Objects;

public class EquPrestamoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Prestamo { get; set; } = null!;
    public string? PrestamoCodigo { get; set; }
    public DateTime? FechaPrestamoFf { get; set; }
    public DateTime? FechaCompromisoFf { get; set; }
    public string? Notas { get; set; }
    public int IdEstadoPrestamo { get; set; }
    public int IdUsuarioEntrego { get; set; }
}
