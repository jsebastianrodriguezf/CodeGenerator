using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class OrtTipoProgramacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoProgramacion { get; set; } = null!;

    public string? TipoProgramacionCodigo { get; set; }

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
}
