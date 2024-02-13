using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class LicCatalogoParametro
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoParametro { get; set; } = null!;

    public int IdCatalogo { get; set; }

    public int IdParametro { get; set; }

    public string ValorXdefecto { get; set; } = null!;

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual LicParametro IdParametroNavigation { get; set; } = null!;
}
