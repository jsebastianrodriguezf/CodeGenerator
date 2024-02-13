using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerContactoSucursal
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContactoSucursal { get; set; } = null!;

    public int IdContacto { get; set; }

    public int IdSucursal { get; set; }

    public virtual TerContacto IdContactoNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
