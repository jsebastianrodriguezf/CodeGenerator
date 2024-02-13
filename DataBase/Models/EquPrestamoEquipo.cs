using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquPrestamoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PrestamoEquipo { get; set; } = null!;

    public DateTime? FechaDevolucionFf { get; set; }

    public int IdPrestamo { get; set; }

    public int IdEquipo { get; set; }

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual EquPrestamo IdPrestamoNavigation { get; set; } = null!;
}
