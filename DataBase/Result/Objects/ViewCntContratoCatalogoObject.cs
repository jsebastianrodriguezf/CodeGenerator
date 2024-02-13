namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntContratoCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoCatalogo { get; set; } = null!;
    public double? Incluida { get; set; }
    public double? Consumida { get; set; }
    public double? Saldo { get; set; }
    public decimal? PrecioVenta { get; set; }
    public string? Notas { get; set; }
    public int IdContrato { get; set; }
    public string CntContratoContrato { get; set; } = null!;
    public string? CntContratoContratoCodigo { get; set; }
    public string CntContratoNumero { get; set; } = null!;
    public decimal? CntContratoTotalContrato { get; set; }
    public decimal? CntContratoPresupuesto { get; set; }
    public DateTime CntContratoFechaInicioFf { get; set; }
    public DateTime? CntContratoFechaFinFf { get; set; }
    public int? CntContratoDiasCumplimiento { get; set; }
    public string? CntContratoCondiciones { get; set; }
    public int CntContratoIdPeriodoContrato { get; set; }
    public int CntContratoIdTercero { get; set; }
    public int CntContratoIdTipoServicio { get; set; }
    public int CntContratoIdTipoContrato { get; set; }
    public int CntContratoIdTerceroServicio { get; set; }
    public int CntContratoIdSubtipoDocumento { get; set; }
    public int CntContratoIdDepartamentoSolicitud { get; set; }
    public int CntContratoIdUsuarioCoordinador { get; set; }
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
