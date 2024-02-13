namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocSubtipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SubtipoDocumento { get; set; } = null!;
    public string? SubtipoDocumentoCodigo { get; set; }
    public string Prefijo { get; set; } = null!;
    public int Consecutivo { get; set; }
    public int IdTipoDocumento { get; set; }
    public string DocTipoDocumentoTipoDocumento { get; set; } = null!;
    public string? DocTipoDocumentoTipoDocumentoCodigo { get; set; }
    public bool DocTipoDocumentoEsSalida { get; set; }
    public bool DocTipoDocumentoMostrarBodega { get; set; }
    public bool DocTipoDocumentoMostrarCentroCosto { get; set; }
    public bool DocTipoDocumentoMostrarIncoterm { get; set; }
    public bool DocTipoDocumentoPuedeSerMayor { get; set; }
    public bool DocTipoDocumentoPuedeSerMenor { get; set; }
    public bool DocTipoDocumentoEsUrgente { get; set; }
    public bool ProgramarPlaneadas { get; set; }
    public bool CargarSolicitante { get; set; }
    public bool VerCentroCosto { get; set; }
    public bool VerIncoterm { get; set; }
    public bool ValUrgente { get; set; }
    public bool BloquearDespacho { get; set; }
    public bool CerrarSol { get; set; }
    public bool EjecutaDevolucion { get; set; }
    public int TipoCobro { get; set; }
    public int MostrarPendienteDocumento { get; set; }
    public bool CantidadAuxiliar { get; set; }
    public bool MostrarValoresEjecutados { get; set; }
    public int ArchivosAdjuntosApp { get; set; }
    public string Multiempresa { get; set; } = null!;
}
