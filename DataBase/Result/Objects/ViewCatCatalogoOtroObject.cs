namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoOtroObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoOtro { get; set; } = null!;
    public decimal Costo { get; set; }
    public int? PeriodoAlquiler { get; set; }
    public string? CatCatalogoOtroCatalogoCodigo { get; set; }
    public string CatCatalogoOtroCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoOtroPrecioVenta { get; set; }
    public int? CatCatalogoOtroTiempoConsecucion { get; set; }
    public bool CatCatalogoOtroEsNacional { get; set; }
    public int CatCatalogoOtroIdFamilia { get; set; }
    public string CatCatalogoOtroGenFamiliaFamilia { get; set; } = null!;
    public string? CatCatalogoOtroGenFamiliaFamiliaCodigo { get; set; }
    public int CatCatalogoOtroGenFamiliaIdFamilia { get; set; }
    public int CatCatalogoOtroIdSubTipoCatalogo { get; set; }
    public string CatCatalogoOtroCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;
    public string? CatCatalogoOtroCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }
    public int CatCatalogoOtroCatSubtipoCatalogoIdTipoCatalogo { get; set; }
    public int CatCatalogoOtroIdUnidad { get; set; }
    public string CatCatalogoOtroGenUnidadUnidad { get; set; } = null!;
    public string? CatCatalogoOtroGenUnidadUnidadCodigo { get; set; }
    public int CatCatalogoOtroIdImpuesto { get; set; }
    public string CatCatalogoOtroGenImpuestoImpuesto { get; set; } = null!;
    public string? CatCatalogoOtroGenImpuestoImpuestoCodigo { get; set; }
    public double? CatCatalogoOtroGenImpuestoValor { get; set; }
    public string CatCatalogoOtroDescripcion { get; set; } = null!;
    public bool CatCatalogoOtroBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
