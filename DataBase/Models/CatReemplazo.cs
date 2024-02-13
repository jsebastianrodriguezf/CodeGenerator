using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatReemplazo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Reemplazo { get; set; } = null!;

    public string? ReemplazoCodigo { get; set; }

    public int IdTipoReemplazo { get; set; }

    public int IdCatalogoRepuesto { get; set; }

    public int IdCatalogoRepuesto1 { get; set; }

    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();

    public virtual CatCatalogoRepuesto IdCatalogoRepuesto1Navigation { get; set; } = null!;

    public virtual CatCatalogoRepuesto IdCatalogoRepuestoNavigation { get; set; } = null!;

    public virtual CatTipoReemplazo IdTipoReemplazoNavigation { get; set; } = null!;
}
