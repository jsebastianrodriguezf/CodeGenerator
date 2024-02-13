using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquPrestamo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Prestamo { get; set; } = null!;

    public string? PrestamoCodigo { get; set; }

    public DateTime? FechaPrestamoFf { get; set; }

    public DateTime? FechaCompromisoFf { get; set; }

    public string? Notas { get; set; }

    public int IdEstadoPrestamo { get; set; }

    public int IdUsuarioEntrego { get; set; }

    public virtual ICollection<EquPrestamoEquipo> EquPrestamoEquipos { get; set; } = new List<EquPrestamoEquipo>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual EquEstadoPrestamo IdEstadoPrestamoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioEntregoNavigation { get; set; } = null!;
}
