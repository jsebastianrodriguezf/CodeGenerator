namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntVisitaFijaCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string VisitaFijaCatalogo { get; set; } = null!;
    public double Cantidad { get; set; }
    public double Precio { get; set; }
    public int IdVisitaFija { get; set; }
    public string CntVisitaFijaVisitaFija { get; set; } = null!;
    public string? CntVisitaFijaVisitaFijaCodigo { get; set; }
    public DateTime CntVisitaFijaFechaFf { get; set; }
    public DateTime CntVisitaFijaFechaCreadaFf { get; set; }
    public double? CntVisitaFijaHorometro { get; set; }
    public int CntVisitaFijaIdDocumentoOt { get; set; }
    public int CntVisitaFijaIdContratoEquipo { get; set; }
    public int CntVisitaFijaIdContratoDetalleVisita { get; set; }
    public int CntVisitaFijaIdCatalogoTempario { get; set; }
    public bool? CntVisitaFijaEsPorTrabajo { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
