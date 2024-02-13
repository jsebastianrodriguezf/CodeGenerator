using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerEstadoTercero
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoTercero { get; set; } = null!;

    public string? EstadoTerceroCodigo { get; set; }

    public virtual ICollection<TerSucursal> TerSucursals { get; set; } = new List<TerSucursal>();

    public virtual ICollection<TerTercero> TerTerceros { get; set; } = new List<TerTercero>();
}
