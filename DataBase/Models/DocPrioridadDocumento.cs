using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocPrioridadDocumento
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

    public int IdEstrategiaPrioridad { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<CntTiempoRespuestum> CntTiempoRespuesta { get; set; } = new List<CntTiempoRespuestum>();

    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocPrioridadSubtipoDocumento> DocPrioridadSubtipoDocumentos { get; set; } = new List<DocPrioridadSubtipoDocumento>();

    public virtual DocEstrategiaPrioridad IdEstrategiaPrioridadNavigation { get; set; } = null!;

    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
}
