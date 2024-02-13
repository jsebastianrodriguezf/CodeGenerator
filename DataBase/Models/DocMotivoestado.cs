using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocMotivoestado
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Motivoestado { get; set; } = null!;

    public string? MotivoestadoCodigo { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();

    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
}
