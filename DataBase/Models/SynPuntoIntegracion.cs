using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SynPuntoIntegracion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PuntoIntegracion { get; set; } = null!;

    public string? PuntoIntegracionCodigo { get; set; }

    public string? TablaLocal { get; set; }

    public string? Condicion { get; set; }

    public string? UrlConsumir { get; set; }

    public int? IdPuntoIntegracion { get; set; }

    public int? IdSistemaIntegrar { get; set; }

    public string? Metodo { get; set; }

    public int? CantidadReintentos { get; set; }

    public int? IntervaloReintentos { get; set; }

    public string? CodigosReintentos { get; set; }

    public virtual ICollection<GenAccionNotificacion> GenAccionNotificacions { get; set; } = new List<GenAccionNotificacion>();

    public virtual SynPuntoIntegracion? IdPuntoIntegracionNavigation { get; set; }

    public virtual SynSistemaIntegrar? IdSistemaIntegrarNavigation { get; set; }

    public virtual ICollection<SynPuntoIntegracion> InverseIdPuntoIntegracionNavigation { get; set; } = new List<SynPuntoIntegracion>();

    public virtual ICollection<SegRegistroIntegracion> SegRegistroIntegracions { get; set; } = new List<SegRegistroIntegracion>();

    public virtual ICollection<SynCampoIntegracion> SynCampoIntegracions { get; set; } = new List<SynCampoIntegracion>();

    public virtual ICollection<SynPuntoIntegracionEstadoTipoDocumento> SynPuntoIntegracionEstadoTipoDocumentos { get; set; } = new List<SynPuntoIntegracionEstadoTipoDocumento>();

    public virtual ICollection<SynPuntoIntegracionTabla> SynPuntoIntegracionTablas { get; set; } = new List<SynPuntoIntegracionTabla>();
}
