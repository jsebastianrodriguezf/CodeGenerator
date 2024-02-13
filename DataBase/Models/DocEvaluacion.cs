using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocEvaluacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Evaluacion { get; set; } = null!;

    public string? EvaluacionCodigo { get; set; }

    public bool Activa { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public virtual ICollection<DocDocumentoEvaluacion> DocDocumentoEvaluacions { get; set; } = new List<DocDocumentoEvaluacion>();

    public virtual ICollection<DocPreguntum> DocPregunta { get; set; } = new List<DocPreguntum>();

    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
}
