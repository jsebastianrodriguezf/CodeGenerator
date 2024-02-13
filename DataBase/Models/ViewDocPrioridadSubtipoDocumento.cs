using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocPrioridadSubtipoDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PrioridadSubtipoDocumento { get; set; } = null!;

    public string? PrioridadSubtipoDocumentoCodigo { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public string DocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocSubtipoDocumentoConsecutivo { get; set; }

    public int DocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public bool DocSubtipoDocumentoCargarSolicitante { get; set; }

    public bool DocSubtipoDocumentoVerCentroCosto { get; set; }

    public bool DocSubtipoDocumentoVerIncoterm { get; set; }

    public bool DocSubtipoDocumentoValUrgente { get; set; }

    public bool DocSubtipoDocumentoBloquearDespacho { get; set; }

    public bool DocSubtipoDocumentoCerrarSol { get; set; }

    public bool DocSubtipoDocumentoEjecutaDevolucion { get; set; }

    public int DocSubtipoDocumentoTipoCobro { get; set; }

    public int DocSubtipoDocumentoMostrarPendienteDocumento { get; set; }

    public bool DocSubtipoDocumentoCantidadAuxiliar { get; set; }

    public int IdPrioridadDocumento { get; set; }

    public string DocPrioridadDocumentoPrioridadDocumento { get; set; } = null!;

    public string? DocPrioridadDocumentoPrioridadDocumentoCodigo { get; set; }

    public int DocPrioridadDocumentoTiempoRespuesta { get; set; }

    public int DocPrioridadDocumentoIdTipoDocumento { get; set; }

    public int DocPrioridadDocumentoIdEstrategiaPrioridad { get; set; }

    public int? DocPrioridadDocumentoOrden { get; set; }

    public string Multiempresa { get; set; } = null!;
}
