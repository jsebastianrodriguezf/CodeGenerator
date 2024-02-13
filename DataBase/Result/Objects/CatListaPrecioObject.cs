namespace SAMMAI.Transverse.Models.Objects;

public class CatListaPrecioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ListaPrecio { get; set; } = null!;
    public string? ListaPrecioCodigo { get; set; }
    public double PorcentajeDescuento { get; set; }
    public bool EsPrivado { get; set; }
    public int IdMoneda { get; set; }
    public bool? ParaCompra { get; set; }
}
