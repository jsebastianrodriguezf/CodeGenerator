using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatAtributoOpcionAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string AtributoOpcionAtributo { get; set; } = null!;

    public int? IdAtributo { get; set; }

    public int? IdOpcionAtributo { get; set; }

    public virtual CatAtributo? IdAtributoNavigation { get; set; }

    public virtual EquOpcionAtributo? IdOpcionAtributoNavigation { get; set; }
}
