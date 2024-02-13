using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GasTipoGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoGasto { get; set; } = null!;

    public string? TipoGastoCodigo { get; set; }

    public virtual ICollection<GasGasto> GasGastos { get; set; } = new List<GasGasto>();
}
