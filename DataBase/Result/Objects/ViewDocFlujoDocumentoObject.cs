namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocFlujoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string FlujoDocumento { get; set; } = null!;
    public string? FlujoDocumentoCodigo { get; set; }
    public bool Restrictivo { get; set; }
    public int IdSubtipoDocumentoOrigen { get; set; }
    public string DocSubtipoDocumentoOrigenSubtipoDocumento { get; set; } = null!;
    public string? DocSubtipoDocumentoOrigenSubtipoDocumentoCodigo { get; set; }
    public string DocSubtipoDocumentoOrigenPrefijo { get; set; } = null!;
    public int DocSubtipoDocumentoOrigenConsecutivo { get; set; }
    public int DocSubtipoDocumentoOrigenIdTipoDocumento { get; set; }
    public int IdSubtipoDocumentoDestino { get; set; }
    public string DocSubtipoDocumentoDestinoSubtipoDocumento { get; set; } = null!;
    public string? DocSubtipoDocumentoDestinoSubtipoDocumentoCodigo { get; set; }
    public string DocSubtipoDocumentoDestinoPrefijo { get; set; } = null!;
    public int DocSubtipoDocumentoDestinoConsecutivo { get; set; }
    public int DocSubtipoDocumentoDestinoIdTipoDocumento { get; set; }
    public int IdEstadoTipoDocumentoOrigen { get; set; }
    public string DocEstadoTipoDocumentoOrigenEstadoTipoDocumento { get; set; } = null!;
    public string? DocEstadoTipoDocumentoOrigenEstadoTipoDocumentoCodigo { get; set; }
    public bool DocEstadoTipoDocumentoOrigenAfectaIndicador { get; set; }
    public bool DocEstadoTipoDocumentoOrigenEditaDocumento { get; set; }
    public int DocEstadoTipoDocumentoOrigenOrden { get; set; }
    public bool DocEstadoTipoDocumentoOrigenPuedeRegresar { get; set; }
    public string DocEstadoTipoDocumentoOrigenColor { get; set; } = null!;
    public bool DocEstadoTipoDocumentoOrigenAfectaInventario { get; set; }
    public int DocEstadoTipoDocumentoOrigenIdTipoDocumento { get; set; }
    public string? DocEstadoTipoDocumentoOrigenDescripcion { get; set; }
    public int IdEstadoTipoDocumentoResultado { get; set; }
    public string DocEstadoTipoDocumentoResultadoEstadoTipoDocumento { get; set; } = null!;
    public string? DocEstadoTipoDocumentoResultadoEstadoTipoDocumentoCodigo { get; set; }
    public bool DocEstadoTipoDocumentoResultadoAfectaIndicador { get; set; }
    public bool DocEstadoTipoDocumentoResultadoEditaDocumento { get; set; }
    public int DocEstadoTipoDocumentoResultadoOrden { get; set; }
    public bool DocEstadoTipoDocumentoResultadoPuedeRegresar { get; set; }
    public string DocEstadoTipoDocumentoResultadoColor { get; set; } = null!;
    public bool DocEstadoTipoDocumentoResultadoAfectaInventario { get; set; }
    public int DocEstadoTipoDocumentoResultadoIdTipoDocumento { get; set; }
    public string? DocEstadoTipoDocumentoResultadoDescripcion { get; set; }
    public int ReplicarItems { get; set; }
    public bool ReplicarAtributos { get; set; }
    public int ReplicarItemsActividades { get; set; }
    public int ReplicarComentario { get; set; }
    public string Multiempresa { get; set; } = null!;
}
