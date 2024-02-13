using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatDetalleRepuesto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetalleRepuesto { get; set; } = null!;

    public string? DetalleRepuestoCodigo { get; set; }

    public double Cantidad { get; set; }

    public int IdCatalogoRepuesto { get; set; }

    public int IdCatalogoRepuestoHijo { get; set; }

    public virtual CatCatalogoRepuesto IdCatalogoRepuestoHijoNavigation { get; set; } = null!;

    public virtual CatCatalogoRepuesto IdCatalogoRepuestoNavigation { get; set; } = null!;
}
