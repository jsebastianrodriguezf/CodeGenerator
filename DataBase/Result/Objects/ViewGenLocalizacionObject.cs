namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenLocalizacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Localizacion { get; set; } = null!;
    public string? LocalizacionCodigo { get; set; }
    public int IdCatalogoBodega { get; set; }
    public double Disponible { get; set; }
    public double Reservado { get; set; }
    public double? EnOrdenes { get; set; }
    public decimal Costo { get; set; }
    public double ExistenciaMinima { get; set; }
    public int IdBodega { get; set; }
    public string CatCatalogoBodegaCatalogo { get; set; } = null!;
    public string? CatCatalogoBodegaCatalogoCodigo { get; set; }
    public string CatCatalogoBodegaCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoBodegaPrecioVenta { get; set; }
    public int? CatCatalogoBodegaTiempoConsecucion { get; set; }
    public bool CatCatalogoBodegaEsNacional { get; set; }
    public int CatCatalogoBodegaIdFamilia { get; set; }
    public int CatCatalogoBodegaIdSubTipoCatalogo { get; set; }
    public int CatCatalogoBodegaIdUnidad { get; set; }
    public int CatCatalogoBodegaIdImpuesto { get; set; }
    public string CatCatalogoBodegaDescripcion { get; set; } = null!;
    public bool CatCatalogoBodegaBloquearCostear { get; set; }
    public int Existencia { get; set; }
    public int ExistenciaMaxima { get; set; }
    public string Multiempresa { get; set; } = null!;
}
