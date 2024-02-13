namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntContratoTipoServicioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoTipoServicio { get; set; } = null!;
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
    public int CntContratoIdDocumentoAlquiler { get; set; }
    public int IdTipoServicio { get; set; }
    public string GenTipoServicioTipoServicio { get; set; } = null!;
    public string? GenTipoServicioTipoServicioCodigo { get; set; }
    public bool? GenTipoServicioTieneGarantia { get; set; }
    public int? GenTipoServicioDiasGarantia { get; set; }
    public int IdListaPrecio { get; set; }
    public string CatListaPrecioListaPrecio { get; set; } = null!;
    public string? CatListaPrecioListaPrecioCodigo { get; set; }
    public double CatListaPrecioPorcentajeDescuento { get; set; }
    public bool CatListaPrecioEsPrivado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
