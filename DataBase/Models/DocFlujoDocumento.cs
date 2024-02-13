using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocFlujoDocumento
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

    public int IdSubtipoDocumentoDestino { get; set; }

    public int IdEstadoTipoDocumentoOrigen { get; set; }

    public int IdEstadoTipoDocumentoResultado { get; set; }

    public int ReplicarItems { get; set; }

    public bool ReplicarAtributos { get; set; }

    public int ReplicarItemsActividades { get; set; }

    public int ReplicarComentario { get; set; }

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoOrigenNavigation { get; set; } = null!;

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoResultadoNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoDestinoNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoOrigenNavigation { get; set; } = null!;
}
