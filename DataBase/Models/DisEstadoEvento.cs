using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisEstadoEvento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoEvento { get; set; } = null!;

    public string? EstadoEventoCodigo { get; set; }

    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();

    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
}
