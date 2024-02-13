namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntTiempoRespuestumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TiempoRespuesta { get; set; } = null!;
    public string? TiempoRespuestaCodigo { get; set; }
    public int TiempoLimite { get; set; }
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
    public int IdPrioridadDocumento { get; set; }
    public string DocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;
    public string? DocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }
    public int DocPrioridadDocumentoTiempoRespuesta { get; set; }
    public int DocPrioridadDocumentoIdTipoDocumento { get; set; }
    public int DocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }
    public int IdEstrategiaPrioridad { get; set; }
    public string DocEstrategiaPrioridadEstrategiaPrioridad { get; set; } = null!;
    public string? DocEstrategiaPrioridadEstrategiaPrioridadCodigo { get; set; }
    public DateTime DocEstrategiaPrioridadLunesIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadLunesFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadMartesIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadMartesFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadMiercolesIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadMiercolesFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadJuevesIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadJuevesFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadViernesIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadViernesFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadSabadoIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadSabadoFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadDomingoIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadDomingoFinHh { get; set; }
    public DateTime DocEstrategiaPrioridadFestivoIniHh { get; set; }
    public DateTime DocEstrategiaPrioridadFestivoFinHh { get; set; }
    public string Multiempresa { get; set; } = null!;
}
