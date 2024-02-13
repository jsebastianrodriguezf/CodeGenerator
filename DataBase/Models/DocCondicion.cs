using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocCondicion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Condicion { get; set; } = null!;

    public string? CondicionCodigo { get; set; }

    public bool TextoLibre { get; set; }

    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();

    public virtual ICollection<DocDocumentoCotizacionCondicion> DocDocumentoCotizacionCondicions { get; set; } = new List<DocDocumentoCotizacionCondicion>();

    public virtual ICollection<DocOpcionCondicion> DocOpcionCondicions { get; set; } = new List<DocOpcionCondicion>();
}
