using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquOpcionAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string OpcionAtributo { get; set; } = null!;

    public string? OpcionAtributoCodigo { get; set; }

    public int Orden { get; set; }

    public int IdAtributo { get; set; }

    public virtual ICollection<CatAtributoOpcionAtributo> CatAtributoOpcionAtributos { get; set; } = new List<CatAtributoOpcionAtributo>();

    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();

    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();

    public virtual ICollection<EquOpcionAtributoDependiente> EquOpcionAtributoDependientes { get; set; } = new List<EquOpcionAtributoDependiente>();

    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
}
