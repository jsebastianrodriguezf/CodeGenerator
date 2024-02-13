namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocPrioridadDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PrioridadDocumento { get; set; } = null!;
    public string? PrioridadDocumentoCodigo { get; set; }
    public int TiempoRespuesta { get; set; }
    public int IdTipoDocumento { get; set; }
    public int? Orden { get; set; }
    public string DocTipoDocumentoTipoDocumento { get; set; } = null!;
    public string? DocTipoDocumentoTipoDocumentoCodigo { get; set; }
    public bool DocTipoDocumentoEsSalida { get; set; }
    public bool DocTipoDocumentoMostrarBodega { get; set; }
    public bool DocTipoDocumentoMostrarCentroCosto { get; set; }
    public bool DocTipoDocumentoMostrarIncoterm { get; set; }
    public bool DocTipoDocumentoPuedeSerMayor { get; set; }
    public bool DocTipoDocumentoPuedeSerMenor { get; set; }
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
