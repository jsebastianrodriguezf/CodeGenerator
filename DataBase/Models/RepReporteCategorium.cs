using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class RepReporteCategorium
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ReporteCategoria { get; set; } = null!;

    public int IdCategoria { get; set; }

    public int IdReporte { get; set; }

    public virtual RepCategorium IdCategoriaNavigation { get; set; } = null!;

    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
