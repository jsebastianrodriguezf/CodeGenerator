namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatDetalleRepuestoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleRepuesto { get; set; } = null!;
    public string? DetalleRepuestoCodigo { get; set; }
    public double Cantidad { get; set; }
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
    public int IdCatalogoRepuestoHijo { get; set; }
    public string CatCatalogoRepuestoHijoCatalogoRepuesto { get; set; } = null!;
    public int? CatCatalogoRepuestoHijoGarantiaDias { get; set; }
    public int? CatCatalogoRepuestoHijoGarantiaHoras { get; set; }
    public bool CatCatalogoRepuestoHijoVigente { get; set; }
    public int CatCatalogoRepuestoHijoIdMarca { get; set; }
    public string? CatCatalogoRepuestoHijoCatalogoCodigo { get; set; }
    public string CatCatalogoRepuestoHijoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoRepuestoHijoPrecioVenta { get; set; }
    public int? CatCatalogoRepuestoHijoTiempoConsecucion { get; set; }
    public bool CatCatalogoRepuestoHijoEsNacional { get; set; }
    public int CatCatalogoRepuestoHijoIdFamilia { get; set; }
    public int CatCatalogoRepuestoHijoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoRepuestoHijoIdUnidad { get; set; }
    public int CatCatalogoRepuestoHijoIdImpuesto { get; set; }
    public string CatCatalogoRepuestoHijoDescripcion { get; set; } = null!;
    public bool CatCatalogoRepuestoHijoBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
