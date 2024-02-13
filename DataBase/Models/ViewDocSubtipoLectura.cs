using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocSubtipoLectura
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SubtipoLectura { get; set; } = null!;

    public string? SubtipoLecturaCodigo { get; set; }

    public int? IdSubtipoDocumento { get; set; }

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

    public int? IdSubtipoDocumentoOrigen { get; set; }

    public string DocSubtipoDocumentoOrigenSubtipoDocumento { get; set; } = null!;

    public string? DocSubtipoDocumentoOrigenSubtipoDocumentoCodigo { get; set; }

    public string DocSubtipoDocumentoOrigenPrefijo { get; set; } = null!;

    public int DocSubtipoDocumentoOrigenConsecutivo { get; set; }

    public int DocSubtipoDocumentoOrigenIdTipoDocumento { get; set; }

    public bool DocSubtipoDocumentoOrigenProgramarPlaneadas { get; set; }

    public bool DocSubtipoDocumentoOrigenCargarSolicitante { get; set; }

    public bool DocSubtipoDocumentoOrigenVerCentroCosto { get; set; }

    public bool DocSubtipoDocumentoOrigenVerIncoterm { get; set; }

    public bool DocSubtipoDocumentoOrigenValUrgente { get; set; }

    public bool DocSubtipoDocumentoOrigenBloquearDespacho { get; set; }

    public bool DocSubtipoDocumentoOrigenCerrarSol { get; set; }

    public bool DocSubtipoDocumentoOrigenEjecutaDevolucion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
