using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewRepCampoReporte
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CampoReporte { get; set; } = null!;

    public string? CampoReporteCodigo { get; set; }

    public int IdReporte { get; set; }

    public string RepReporteReporte { get; set; } = null!;

    public string? RepReporteReporteCodigo { get; set; }

    public int RepReporteIdFuncionalidad { get; set; }

    public bool RepReporteEsFormato { get; set; }

    public bool RepReporteTieneGraficos { get; set; }

    public string RepReporteCabecera { get; set; } = null!;

    public int IdTipoCampoReporte { get; set; }

    public string RepTipoCampoReporteTipoCampoReporte { get; set; } = null!;

    public string? RepTipoCampoReporteTipoCampoReporteCodigo { get; set; }

    public string Tabla { get; set; } = null!;

    public string ValorDefecto { get; set; } = null!;

    public bool EsParametro { get; set; }

    public bool EsSerie { get; set; }

    public bool ParametroTotal { get; set; }

    public string Multiempresa { get; set; } = null!;
}
