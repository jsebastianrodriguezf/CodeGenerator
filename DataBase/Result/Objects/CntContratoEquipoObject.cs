namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoEquipo { get; set; } = null!;
    public string? ContratoEquipoCodigo { get; set; }
    public decimal? PrecioVisita { get; set; }
    public decimal? PrecioServicio { get; set; }
    public DateTime? FechaFf { get; set; }
    public double? Promedio { get; set; }
    public int IdEquipo { get; set; }
    public int IdContrato { get; set; }
    public int IdContratoDetalleVisita { get; set; }
}
