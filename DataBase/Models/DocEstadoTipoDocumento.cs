using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocEstadoTipoDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoTipoDocumento { get; set; } = null!;

    public string? EstadoTipoDocumentoCodigo { get; set; }

    public bool AfectaIndicador { get; set; }

    public bool EditaDocumento { get; set; }

    public int Orden { get; set; }

    public bool PuedeRegresar { get; set; }

    public string Color { get; set; } = null!;

    public bool AfectaInventario { get; set; }

    public int IdTipoDocumento { get; set; }

    public string? Descripcion { get; set; }

    public bool ObservacionesObligatorio { get; set; }

    public bool MotivoObligatorio { get; set; }

    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();

    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();

    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocEstadoTipoDocumentoPerfil> DocEstadoTipoDocumentoPerfils { get; set; } = new List<DocEstadoTipoDocumentoPerfil>();

    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoDestinoNavigations { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();

    public virtual ICollection<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoNavigations { get; set; } = new List<DocEstadoTipoDocumentoSubtipoDocumento>();

    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdEstadoTipoDocumentoOrigenNavigations { get; set; } = new List<DocFlujoDocumento>();

    public virtual ICollection<DocFlujoDocumento> DocFlujoDocumentoIdEstadoTipoDocumentoResultadoNavigations { get; set; } = new List<DocFlujoDocumento>();

    public virtual ICollection<DocMotivoestado> DocMotivoestados { get; set; } = new List<DocMotivoestado>();

    public virtual ICollection<GasGasto> GasGastos { get; set; } = new List<GasGasto>();

    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();

    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<SynPuntoIntegracionEstadoTipoDocumento> SynPuntoIntegracionEstadoTipoDocumentos { get; set; } = new List<SynPuntoIntegracionEstadoTipoDocumento>();
}
