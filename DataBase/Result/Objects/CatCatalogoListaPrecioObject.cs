namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoListaPrecioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoListaPrecio { get; set; } = null!;
    public decimal PrecioVenta { get; set; }
    public int IdCatalogo { get; set; }
    public int IdListaPrecio { get; set; }
    public double? PorcDto { get; set; }
}
