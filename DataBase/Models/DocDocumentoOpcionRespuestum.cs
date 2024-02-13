using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoOpcionRespuestum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOpcionRespuesta { get; set; } = null!;

    public int IdDocumento { get; set; }

    public int IdOpcionRespuesta { get; set; }

    public int IdPregunta { get; set; }

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual DocOpcionRespuestum IdOpcionRespuestaNavigation { get; set; } = null!;

    public virtual DocPreguntum IdPreguntaNavigation { get; set; } = null!;
}
