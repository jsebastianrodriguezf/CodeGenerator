using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquTipoTrazabilidad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoTrazabilidad { get; set; } = null!;

    public string? TipoTrazabilidadCodigo { get; set; }

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
}
