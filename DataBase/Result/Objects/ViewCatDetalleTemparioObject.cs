namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatDetalleTemparioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleTempario { get; set; } = null!;
    public string? DetalleTemparioCodigo { get; set; }
    public double CantidadEstandar { get; set; }
    public int Orden { get; set; }
    public double CantidadTropicalizada { get; set; }
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
    public int IdCatalogoTempario { get; set; }
    public string CatCatalogoTemparioCatalogoTempario { get; set; } = null!;
    public double? CatCatalogoTemparioDuracionEstimada { get; set; }
    public bool CatCatalogoTemparioEnTaller { get; set; }
    public bool CatCatalogoTemparioEsCiclico { get; set; }
    public bool CatCatalogoTemparioDetieneEquipos { get; set; }
    public double? CatCatalogoTemparioHorasDetencion { get; set; }
    public int CatCatalogoTemparioPeriodoHoras { get; set; }
    public bool CatCatalogoTemparioFacturaTodo { get; set; }
    public int CatCatalogoTemparioPeriodoDias { get; set; }
    public double CatCatalogoTemparioPorcGarantia { get; set; }
    public double CatCatalogoTemparioPorcTropicalizacion { get; set; }
    public int CatCatalogoTemparioIdTipoServicio { get; set; }
    public bool CatCatalogoTemparioProyectar { get; set; }
    public bool CatCatalogoTemparioIncluirMenores { get; set; }
    public int CatCatalogoTemparioModoAjuste { get; set; }
    public string? CatCatalogoTemparioCatalogoCodigo { get; set; }
    public string CatCatalogoTemparioCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoTemparioPrecioVenta { get; set; }
    public int? CatCatalogoTemparioTiempoConsecucion { get; set; }
    public bool CatCatalogoTemparioEsNacional { get; set; }
    public int CatCatalogoTemparioIdFamilia { get; set; }
    public int CatCatalogoTemparioIdSubtipoCatalogo { get; set; }
    public int CatCatalogoTemparioIdUnidad { get; set; }
    public int CatCatalogoTemparioIdImpuesto { get; set; }
    public string CatCatalogoTemparioDescripcion { get; set; } = null!;
    public bool CatCatalogoTemparioBloquearCostear { get; set; }
    public int IdPruebaCheckList { get; set; }
    public string CatPruebaCheckListPruebaCheckList { get; set; } = null!;
    public string? CatPruebaCheckListPruebaCheckListCodigo { get; set; }
    public int IdSistema { get; set; }
    public string CatSistemaSistema { get; set; } = null!;
    public string? CatSistemaSistemaCodigo { get; set; }
    public int IdDetalleTemparioPadre { get; set; }
    public string CatDetalleTemparioPadreDetalleTempario { get; set; } = null!;
    public string? CatDetalleTemparioPadreDetalleTemparioCodigo { get; set; }
    public double CatDetalleTemparioPadreCantidadEstandar { get; set; }
    public int CatDetalleTemparioPadreOrden { get; set; }
    public double CatDetalleTemparioPadreCantidadTropicalizada { get; set; }
    public int CatDetalleTemparioPadreIdCatalogo { get; set; }
    public int CatDetalleTemparioPadreIdCatalogoTempario { get; set; }
    public int CatDetalleTemparioPadreIdPruebaCheckList { get; set; }
    public int CatDetalleTemparioPadreIdSistema { get; set; }
    public int CatDetalleTemparioPadreIdDetalleTemparioPadre { get; set; }
    public string Multiempresa { get; set; } = null!;
}
