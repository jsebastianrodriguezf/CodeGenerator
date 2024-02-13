namespace SAMMAI.Transverse.Models.Objects;

public class CatTipoCatalogoListaPrecioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TipoCatalogoListaPrecio { get; set; } = null!;
    public double Porcentaje { get; set; }
    public int IdTipoCatalogo { get; set; }
    public int IdListaPrecio { get; set; }
}
