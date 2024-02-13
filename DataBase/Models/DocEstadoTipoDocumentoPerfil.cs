using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocEstadoTipoDocumentoPerfil
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoTipoDocumentoPerfil { get; set; } = null!;

    public int IdEstadoTipoDocumento { get; set; }

    public int IdPerfil { get; set; }

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;

    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
