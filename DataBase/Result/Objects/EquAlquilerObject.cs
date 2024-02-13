namespace SAMMAI.Transverse.Models.Objects;

public class EquAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Alquiler { get; set; } = null!;
    public string? AlquilerCodigo { get; set; }
    public DateTime FechaCompromisoFf { get; set; }
    public int IdSucursal { get; set; }
    public int IdTercero { get; set; }
    public int IdSubtipoDocumento { get; set; }
    public DateTime? FechaFinFf { get; set; }
    public bool MesVencido { get; set; }
    public int AlquilerNumero { get; set; }
    public string? Observaciones { get; set; }
    public int IdDocumento { get; set; }
}
