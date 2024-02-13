using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntContratoTipoServicio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContratoTipoServicio { get; set; } = null!;

    public int IdContrato { get; set; }

    public int IdTipoServicio { get; set; }

    public int IdListaPrecio { get; set; }

    public virtual CntContrato IdContratoNavigation { get; set; } = null!;

    public virtual CatListaPrecio IdListaPrecioNavigation { get; set; } = null!;

    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
}
