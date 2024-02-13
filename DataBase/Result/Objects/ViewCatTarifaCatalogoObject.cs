namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatTarifaCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TarifaCatalogo { get; set; } = null!;
    public string? TarifaCatalogoCodigo { get; set; }
    public int IdCatalogoTarifa { get; set; }
    public string CatCatalogoTarifaCatalogo { get; set; } = null!;
    public string? CatCatalogoTarifaCatalogoCodigo { get; set; }
    public string CatCatalogoTarifaCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoTarifaPrecioVenta { get; set; }
    public int? CatCatalogoTarifaTiempoConsecucion { get; set; }
    public bool CatCatalogoTarifaEsNacional { get; set; }
    public int CatCatalogoTarifaIdFamilia { get; set; }
    public int CatCatalogoTarifaIdSubTipoCatalogo { get; set; }
    public int CatCatalogoTarifaIdUnidad { get; set; }
    public int CatCatalogoTarifaIdImpuesto { get; set; }
    public string CatCatalogoTarifaDescripcion { get; set; } = null!;
    public bool CatCatalogoTarifaBloquearCostear { get; set; }
    public int IdCatalogoElemento { get; set; }
    public string CatCatalogoElementoCatalogo { get; set; } = null!;
    public string? CatCatalogoElementoCatalogoCodigo { get; set; }
    public string CatCatalogoElementoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoElementoPrecioVenta { get; set; }
    public int? CatCatalogoElementoTiempoConsecucion { get; set; }
    public bool CatCatalogoElementoEsNacional { get; set; }
    public int CatCatalogoElementoIdFamilia { get; set; }
    public int CatCatalogoElementoIdSubTipoCatalogo { get; set; }
    public int CatCatalogoElementoIdUnidad { get; set; }
    public int CatCatalogoElementoIdImpuesto { get; set; }
    public string CatCatalogoElementoDescripcion { get; set; } = null!;
    public bool CatCatalogoElementoBloquearCostear { get; set; }
    public int IdTipotarifa { get; set; }
    public string AlqTipoTarifaTipoTarifa { get; set; } = null!;
    public string? AlqTipoTarifaTipoTarifaCodigo { get; set; }
    public decimal? AlqTipoTarifaValor { get; set; }
    public string Multiempresa { get; set; } = null!;
}
