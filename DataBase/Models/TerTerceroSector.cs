using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerTerceroSector
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TerceroSector { get; set; } = null!;

    public int IdTercero { get; set; }

    public int IdSector { get; set; }

    public virtual TerSector IdSectorNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
