using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatReemplazoCatalogoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ReemplazoCatalogoEquipo { get; set; } = null!;

    public int IdReemplazo { get; set; }

    public int IdVersionEquipo { get; set; }

    public int IdCatalogoEquipo { get; set; }

    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;

    public virtual CatReemplazo IdReemplazoNavigation { get; set; } = null!;

    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
}
