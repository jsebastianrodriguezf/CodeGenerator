using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class OrtMotivoCancelacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string MotivoCancelacion { get; set; } = null!;

    public string? MotivoCancelacionCodigo { get; set; }

    public bool? ResponsableServicio { get; set; }

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
}
