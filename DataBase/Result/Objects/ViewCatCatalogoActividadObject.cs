namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoActividadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoActividad { get; set; } = null!;
    public bool? EsProductiva { get; set; }
    public double? DuracionEstimada { get; set; }
    public string? Procedimiento { get; set; }
    public int DiasGarantia { get; set; }
    public string? CatCatalogoActividadCatalogoCodigo { get; set; }
    public string CatCatalogoActividadCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoActividadPrecioVenta { get; set; }
    public int? CatCatalogoActividadTiempoConsecucion { get; set; }
    public bool CatCatalogoActividadEsNacional { get; set; }
    public int CatCatalogoActividadIdFamilia { get; set; }
    public string CatCatalogoActividadGenFamiliaFamilia { get; set; } = null!;
    public string? CatCatalogoActividadGenFamiliaFamiliaCodigo { get; set; }
    public int CatCatalogoActividadGenFamiliaIdFamilia { get; set; }
    public int CatCatalogoActividadIdSubtipoCatalogo { get; set; }
    public string CatCatalogoActividadCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;
    public string? CatCatalogoActividadCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }
    public int CatCatalogoActividadCatSubtipoCatalogoIdTipoCatalogo { get; set; }
    public int CatCatalogoActividadIdUnidad { get; set; }
    public string CatCatalogoActividadGenUnidadUnidad { get; set; } = null!;
    public string? CatCatalogoActividadGenUnidadUnidadCodigo { get; set; }
    public int CatCatalogoActividadIdImpuesto { get; set; }
    public string CatCatalogoActividadGenImpuestoImpuesto { get; set; } = null!;
    public string? CatCatalogoActividadGenImpuestoImpuestoCodigo { get; set; }
    public double? CatCatalogoActividadGenImpuestoValor { get; set; }
    public string CatCatalogoActividadDescripcion { get; set; } = null!;
    public bool CatCatalogoActividadBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
