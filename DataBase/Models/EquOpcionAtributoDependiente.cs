using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquOpcionAtributoDependiente
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string OpcionAtributoDependiente { get; set; } = null!;

    public string? OpcionAtributoDependienteCodigo { get; set; }

    public int? IdOpcionAtributoHijo { get; set; }

    public int? IdOpcionAtributoPadre { get; set; }

    public virtual EquOpcionAtributo? IdOpcionAtributoHijoNavigation { get; set; }
}
