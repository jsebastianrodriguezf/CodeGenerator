using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatSeccionAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SeccionAtributo { get; set; } = null!;

    public string? SeccionAtributoCodigo { get; set; }

    public int Orden { get; set; }

    public int IdUsoSeccionAtributo { get; set; }

    public virtual ICollection<CatAtributo> CatAtributos { get; set; } = new List<CatAtributo>();

    public virtual CatUsoSeccionAtributo IdUsoSeccionAtributoNavigation { get; set; } = null!;
}
