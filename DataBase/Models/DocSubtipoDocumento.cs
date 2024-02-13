using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocSubtipoDocumento
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

    public virtual ICollection<CntContrato> CntContratoIdSubtipoDocumentoNavigations { get; set; } = new List<CntContrato>();

    public virtual ICollection<CntContrato> CntContratoIdSubtipoDocumentoSolicitudNavigations { get; set; } = new List<CntContrato>();

    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentos { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();

    public virtual ICollection<DocEvaluacion> DocEvaluacions { get; set; } = new List<DocEvaluacion>();

    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdSubtipoDocumentoDestinoNavigations { get; set; } = new List<DocFlujoDocumento>();

    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdSubtipoDocumentoOrigenNavigations { get; set; } = new List<DocFlujoDocumento>();

    public virtual ICollection<DocPrioridadSubtipoDocumento> DocPrioridadSubtipoDocumentos { get; set; } = new List<DocPrioridadSubtipoDocumento>();

    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();

    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();

    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<SegPerfilSubtipoDocumento> SegPerfilSubtipoDocumentos { get; set; } = new List<SegPerfilSubtipoDocumento>();
}
