using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class AlqTipoTarifa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoTarifa { get; set; } = null!;

    public string? TipoTarifaCodigo { get; set; }

    public decimal? Valor { get; set; }

    public virtual ICollection<AlqTarifa> AlqTarifas { get; set; } = new List<AlqTarifa>();
}
