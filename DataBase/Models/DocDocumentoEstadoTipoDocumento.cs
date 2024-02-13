using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoEstadoTipoDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? Notas { get; set; }

    public int IdDocumento { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public int IdMotivoestado { get; set; }

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;

    public virtual DocMotivoestado IdMotivoestadoNavigation { get; set; } = null!;
}
