namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoEquipo { get; set; } = null!;
    public int? GarantiaMeses { get; set; }
    public int? GarantiaHoras { get; set; }
    public bool ManejaHorometro { get; set; }
    public int IdMarca { get; set; }
    public string CatMarcaMarca { get; set; } = null!;
    public string? CatMarcaMarcaCodigo { get; set; }
    public int CatMarcaIdTerceroFabricante { get; set; }
    public string? CatCatalogoEquipoCatalogoCodigo { get; set; }
    public string CatCatalogoEquipoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoEquipoPrecioVenta { get; set; }
    public int? CatCatalogoEquipoTiempoConsecucion { get; set; }
    public bool CatCatalogoEquipoEsNacional { get; set; }
    public int CatCatalogoEquipoIdFamilia { get; set; }
    public string CatCatalogoEquipoGenFamiliaFamilia { get; set; } = null!;
    public string? CatCatalogoEquipoGenFamiliaFamiliaCodigo { get; set; }
    public int CatCatalogoEquipoGenFamiliaIdFamilia { get; set; }
    public int CatCatalogoEquipoIdSubtipoCatalogo { get; set; }
    public string CatCatalogoEquipoCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;
    public string? CatCatalogoEquipoCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }
    public int CatCatalogoEquipoCatSubtipoCatalogoIdTipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public string CatCatalogoEquipoGenUnidadUnidad { get; set; } = null!;
    public string? CatCatalogoEquipoGenUnidadUnidadCodigo { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoGenImpuestoImpuesto { get; set; } = null!;
    public string? CatCatalogoEquipoGenImpuestoImpuestoCodigo { get; set; }
    public double? CatCatalogoEquipoGenImpuestoValor { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public bool CatCatalogoEquipoBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
