using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocPendienteDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PendienteDocumento { get; set; } = null!;

    public string? PendienteDocumentoCodigo { get; set; }

    public double? Cantidad { get; set; }

    public int IdDocumento { get; set; }

    public int IdCatalogo { get; set; }

    public int IdTipoDocumento { get; set; }

    public bool Olvidar { get; set; }

    public int IdReporteTecnico { get; set; }

    public int IdTipoPendiente { get; set; }

    public virtual ICollection<DocPendienteDocumentoDocItemDocumento> DocPendienteDocumentoDocItemDocumentos { get; set; } = new List<DocPendienteDocumentoDocItemDocumento>();

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;

    public virtual DocTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
}
