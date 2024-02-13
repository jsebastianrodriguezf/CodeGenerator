using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoContacto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoContacto { get; set; } = null!;

    public int IdDocumento { get; set; }

    public int IdContacto { get; set; }

    public virtual TerContacto IdContactoNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
}
