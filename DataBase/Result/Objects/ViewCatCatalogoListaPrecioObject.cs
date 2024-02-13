namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoListaPrecioObject
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
    public string CatCatalogoCatalogo { get; set; } = null!;
    public string? CatCatalogoCatalogoCodigo { get; set; }
    public string CatCatalogoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoPrecioVenta { get; set; }
    public int? CatCatalogoTiempoConsecucion { get; set; }
    public bool CatCatalogoEsNacional { get; set; }
    public int CatCatalogoIdFamilia { get; set; }
    public int CatCatalogoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoIdUnidad { get; set; }
    public int CatCatalogoIdImpuesto { get; set; }
    public string CatCatalogoDescripcion { get; set; } = null!;
    public bool CatCatalogoBloquearCostear { get; set; }
    public int IdListaPrecio { get; set; }
    public string CatListaPrecioListaPrecio { get; set; } = null!;
    public string? CatListaPrecioListaPrecioCodigo { get; set; }
    public double CatListaPrecioPorcentajeDescuento { get; set; }
    public bool CatListaPrecioEsPrivado { get; set; }
    public int CatListaPrecioIdMoneda { get; set; }
    public bool? CatListaPrecioParaCompra { get; set; }
    public double? PorcDto { get; set; }
    public string Multiempresa { get; set; } = null!;
}
