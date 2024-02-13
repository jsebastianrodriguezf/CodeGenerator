using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerSucursalListaprecio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SucursalListaprecio { get; set; } = null!;

    public int IdSucursal { get; set; }

    public int IdListaprecio { get; set; }

    public virtual CatListaPrecio IdListaprecioNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
