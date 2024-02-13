using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatTipoReemplazo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoReemplazo { get; set; } = null!;

    public string? TipoReemplazoCodigo { get; set; }

    public virtual ICollection<CatReemplazo> CatReemplazos { get; set; } = new List<CatReemplazo>();
}
