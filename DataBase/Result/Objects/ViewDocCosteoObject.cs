namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocCosteoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Costeo { get; set; } = null!;
    public string? CosteoCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
