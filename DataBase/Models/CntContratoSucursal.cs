using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntContratoSucursal
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContratoSucursal { get; set; } = null!;

    public decimal PrecioVisita { get; set; }

    public decimal PrecioServicio { get; set; }

    public int IdContrato { get; set; }

    public int IdSucursal { get; set; }

    public decimal? Presupuesto { get; set; }

    public virtual CntContrato IdContratoNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
