using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquEstadoPrestamo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoPrestamo { get; set; } = null!;

    public string? EstadoPrestamoCodigo { get; set; }

    public virtual ICollection<EquPrestamo> EquPrestamos { get; set; } = new List<EquPrestamo>();
}
