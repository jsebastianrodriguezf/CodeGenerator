namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatReemplazoCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ReemplazoCatalogoEquipo { get; set; } = null!;
    public int IdReemplazo { get; set; }
    public string CatReemplazoReemplazo { get; set; } = null!;
    public string? CatReemplazoReemplazoCodigo { get; set; }
    public int CatReemplazoIdTipoReemplazo { get; set; }
    public int CatReemplazoIdCatalogoRepuesto { get; set; }
    public int CatReemplazoIdCatalogoRepuesto1 { get; set; }
    public int IdVersionEquipo { get; set; }
    public string CatVersionEquipoVersionEquipo { get; set; } = null!;
    public string? CatVersionEquipoVersionEquipoCodigo { get; set; }
    public int CatVersionEquipoIdCatalogoEquipo { get; set; }
    public int IdCatalogoEquipo { get; set; }
    public string CatCatalogoEquipoCatalogoEquipo { get; set; } = null!;
    public int? CatCatalogoEquipoGarantiaMeses { get; set; }
    public int? CatCatalogoEquipoGarantiaHoras { get; set; }
    public bool CatCatalogoEquipoManejaHorometro { get; set; }
    public int CatCatalogoEquipoIdMarca { get; set; }
    public string? CatCatalogoEquipoCatalogoCodigo { get; set; }
    public string CatCatalogoEquipoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoEquipoPrecioVenta { get; set; }
    public int? CatCatalogoEquipoTiempoConsecucion { get; set; }
    public bool CatCatalogoEquipoEsNacional { get; set; }
    public int CatCatalogoEquipoIdFamilia { get; set; }
    public int CatCatalogoEquipoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public bool CatCatalogoEquipoBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
