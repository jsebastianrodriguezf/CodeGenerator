namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoZonaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoZona { get; set; } = null!;
    public decimal PrecioVisita { get; set; }
    public decimal PrecioServicio { get; set; }
    public int IdContrato { get; set; }
    public int IdZona { get; set; }
}
