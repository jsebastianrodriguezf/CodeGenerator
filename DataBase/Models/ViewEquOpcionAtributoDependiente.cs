using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquOpcionAtributoDependiente
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

    public string EquOpcionAtributoHijoOpcionAtributo { get; set; } = null!;

    public string? EquOpcionAtributoHijoOpcionAtributoCodigo { get; set; }

    public int EquOpcionAtributoHijoOrden { get; set; }

    public int EquOpcionAtributoHijoIdAtributo { get; set; }

    public int? IdOpcionAtributoPadre { get; set; }

    public string EquOpcionAtributoPadreOpcionAtributo { get; set; } = null!;

    public string? EquOpcionAtributoPadreOpcionAtributoCodigo { get; set; }

    public int EquOpcionAtributoPadreOrden { get; set; }

    public int EquOpcionAtributoPadreIdAtributo { get; set; }

    public string Multiempresa { get; set; } = null!;
}
