namespace SAMMAI.Transverse.Models.Objects;

public class ComComisionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Comision { get; set; } = null!;
    public string? ComisionCodigo { get; set; }
    public double? DescuentoMaximo { get; set; }
    public double? DescuentoMinimo { get; set; }
    public int IdCargo { get; set; }
    public int IdSubtipoCatalogo { get; set; }
    public bool? Costear { get; set; }
    public int? Nivelnegocio { get; set; }
    public double? PorcComision { get; set; }
    public int IdCondicion { get; set; }
    public int IdOpcionCondicion { get; set; }
    public int IdZona { get; set; }
}
