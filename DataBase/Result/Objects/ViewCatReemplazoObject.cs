namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatReemplazoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Reemplazo { get; set; } = null!;
    public string? ReemplazoCodigo { get; set; }
    public int IdTipoReemplazo { get; set; }
    public string CatTipoReemplazoTipoReemplazo { get; set; } = null!;
    public string? CatTipoReemplazoTipoReemplazoCodigo { get; set; }
    public int IdCatalogoRepuesto { get; set; }
    public string CatCatalogoRepuestoCatalogoRepuesto { get; set; } = null!;
    public int? CatCatalogoRepuestoGarantiaDias { get; set; }
    public int? CatCatalogoRepuestoGarantiaHoras { get; set; }
    public bool CatCatalogoRepuestoVigente { get; set; }
    public int CatCatalogoRepuestoIdMarca { get; set; }
    public string? CatCatalogoRepuestoCatalogoCodigo { get; set; }
    public string CatCatalogoRepuestoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoRepuestoPrecioVenta { get; set; }
    public int? CatCatalogoRepuestoTiempoConsecucion { get; set; }
    public bool CatCatalogoRepuestoEsNacional { get; set; }
    public int CatCatalogoRepuestoIdFamilia { get; set; }
    public int CatCatalogoRepuestoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoRepuestoIdUnidad { get; set; }
    public int CatCatalogoRepuestoIdImpuesto { get; set; }
    public string CatCatalogoRepuestoDescripcion { get; set; } = null!;
    public bool CatCatalogoRepuestoBloquearCostear { get; set; }
    public int IdCatalogoRepuesto1 { get; set; }
    public string CatCatalogoRepuesto1CatalogoRepuesto { get; set; } = null!;
    public int? CatCatalogoRepuesto1GarantiaDias { get; set; }
    public int? CatCatalogoRepuesto1GarantiaHoras { get; set; }
    public bool CatCatalogoRepuesto1Vigente { get; set; }
    public int CatCatalogoRepuesto1IdMarca { get; set; }
    public string? CatCatalogoRepuesto1CatalogoCodigo { get; set; }
    public string CatCatalogoRepuesto1CodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoRepuesto1PrecioVenta { get; set; }
    public int? CatCatalogoRepuesto1TiempoConsecucion { get; set; }
    public bool CatCatalogoRepuesto1EsNacional { get; set; }
    public int CatCatalogoRepuesto1IdFamilia { get; set; }
    public int CatCatalogoRepuesto1IdSubtipoCatalogo { get; set; }
    public int CatCatalogoRepuesto1IdUnidad { get; set; }
    public int CatCatalogoRepuesto1IdImpuesto { get; set; }
    public string CatCatalogoRepuesto1Descripcion { get; set; } = null!;
    public bool CatCatalogoRepuesto1BloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
