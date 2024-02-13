using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewRepReporteCategorium
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

    public string RepCategoriaCategoria { get; set; } = null!;

    public string? RepCategoriaCategoriaCodigo { get; set; }

    public int RepCategoriaIdCategoria { get; set; }

    public int IdReporte { get; set; }

    public string RepReporteReporte { get; set; } = null!;

    public string? RepReporteReporteCodigo { get; set; }

    public int RepReporteIdFuncionalidad { get; set; }

    public bool RepReporteEsFormato { get; set; }

    public bool RepReporteTieneGraficos { get; set; }

    public string RepReporteCabecera { get; set; } = null!;

    public int RepReporteOrden { get; set; }

    public bool RepReporteBasica { get; set; }

    public string Multiempresa { get; set; } = null!;
}
