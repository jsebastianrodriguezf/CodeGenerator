namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoRepuestoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoRepuesto { get; set; } = null!;
    public int? GarantiaDias { get; set; }
    public int? GarantiaHoras { get; set; }
    public bool Vigente { get; set; }
    public int IdMarca { get; set; }
    public string CatMarcaMarca { get; set; } = null!;
    public string? CatMarcaMarcaCodigo { get; set; }
    public int CatMarcaIdTerceroFabricante { get; set; }
    public double? Peso { get; set; }
    public string? CatCatalogoRepuestoCatalogoCodigo { get; set; }
    public string CatCatalogoRepuestoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoRepuestoPrecioVenta { get; set; }
    public int? CatCatalogoRepuestoTiempoConsecucion { get; set; }
    public bool CatCatalogoRepuestoEsNacional { get; set; }
    public int CatCatalogoRepuestoIdFamilia { get; set; }
    public string CatCatalogoRepuestoGenFamiliaFamilia { get; set; } = null!;
    public string? CatCatalogoRepuestoGenFamiliaFamiliaCodigo { get; set; }
    public int CatCatalogoRepuestoGenFamiliaIdFamilia { get; set; }
    public int CatCatalogoRepuestoIdSubTipoCatalogo { get; set; }
    public string CatCatalogoRepuestoCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;
    public string? CatCatalogoRepuestoCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }
    public int CatCatalogoRepuestoCatSubtipoCatalogoIdTipoCatalogo { get; set; }
    public int CatCatalogoRepuestoIdUnidad { get; set; }
    public string CatCatalogoRepuestoGenUnidadUnidad { get; set; } = null!;
    public string? CatCatalogoRepuestoGenUnidadUnidadCodigo { get; set; }
    public int CatCatalogoRepuestoIdImpuesto { get; set; }
    public string CatCatalogoRepuestoGenImpuestoImpuesto { get; set; } = null!;
    public string? CatCatalogoRepuestoGenImpuestoImpuestoCodigo { get; set; }
    public double? CatCatalogoRepuestoGenImpuestoValor { get; set; }
    public string CatCatalogoRepuestoDescripcion { get; set; } = null!;
    public bool CatCatalogoRepuestoBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
