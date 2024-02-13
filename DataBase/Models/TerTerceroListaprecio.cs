using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerTerceroListaprecio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TerceroListaprecio { get; set; } = null!;

    public int IdTercero { get; set; }

    public int IdListaprecio { get; set; }

    public virtual CatListaPrecio IdListaprecioNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
