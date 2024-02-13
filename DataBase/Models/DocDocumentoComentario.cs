using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoComentario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoComentario { get; set; } = null!;

    public string? DocumentoComentarioCodigo { get; set; }

    public string Comentario { get; set; } = null!;

    public bool Recordar { get; set; }

    public int IdDocumento { get; set; }

    public int IdUsuario { get; set; }

    public int IdTarea { get; set; }

    public DateTime FechaRecordarFh { get; set; }

    public bool Cerrada { get; set; }

    public int IdDocumentoComentario { get; set; }

    public int IdContacto { get; set; }

    public DateTime FechaOrden { get; set; }

    public DateTime FechaOriginal { get; set; }

    public int IdUsuarioOriginal { get; set; }

    public int ConRespuesta { get; set; }

    public int Relevante { get; set; }

    public int IdReporteTecnico { get; set; }

    public int Finalizado { get; set; }

    public virtual TerContacto IdContactoNavigation { get; set; } = null!;

    public virtual DocDocumentoComentario IdDocumentoComentarioNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<DocDocumentoComentario> InverseIdDocumentoComentarioNavigation { get; set; } = new List<DocDocumentoComentario>();
}
