using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquTipoFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoFalla { get; set; } = null!;

    public string? TipoFallaCodigo { get; set; }

    public virtual ICollection<EquFalla> EquFallas { get; set; } = new List<EquFalla>();
}
