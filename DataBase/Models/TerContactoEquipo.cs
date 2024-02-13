using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerContactoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContactoEquipo { get; set; } = null!;

    public int IdEquipo { get; set; }

    public int IdUsuario { get; set; }

    public bool EstadoContacto { get; set; }

    public int IdContacto { get; set; }

    public virtual TerContacto IdContactoNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
