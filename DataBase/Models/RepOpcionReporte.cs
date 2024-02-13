using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class RepOpcionReporte
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string OpcionReporte { get; set; } = null!;

    public string? OpcionReporteCodigo { get; set; }

    public int IdReporte { get; set; }

    public bool Defecto { get; set; }

    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
