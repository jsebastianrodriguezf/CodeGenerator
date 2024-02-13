using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoProyectoEjecutore
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoProyectoEjecutores { get; set; } = null!;

    public int IdEjecutores { get; set; }

    public int IdDocumentoProyecto { get; set; }

    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;

    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
}
