using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocOpcionRespuestum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string OpcionRespuesta { get; set; } = null!;

    public string? OpcionRespuestaCodigo { get; set; }

    public int Orden { get; set; }

    public bool Activa { get; set; }

    public int Valor { get; set; }

    public int IdPregunta { get; set; }

    public virtual ICollection<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuesta { get; set; } = new List<DocDocumentoOpcionRespuestum>();

    public virtual DocPreguntum IdPreguntaNavigation { get; set; } = null!;
}
