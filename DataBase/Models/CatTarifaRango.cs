using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatTarifaRango
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TarifaRango { get; set; } = null!;

    public string? TarifaRangoCodigo { get; set; }

    public double? RangoInicio { get; set; }

    public double? RangoFin { get; set; }

    public double? Precio { get; set; }

    public int IdTarifa { get; set; }

    public virtual CatTarifa IdTarifaNavigation { get; set; } = null!;
}
