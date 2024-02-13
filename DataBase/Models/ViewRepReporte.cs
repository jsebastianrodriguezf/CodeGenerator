using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewRepReporte
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Reporte { get; set; } = null!;

    public string? ReporteCodigo { get; set; }

    public int IdFuncionalidad { get; set; }

    public string GuiFuncionalidadFuncionalidad { get; set; } = null!;

    public string? GuiFuncionalidadFuncionalidadCodigo { get; set; }

    public string? GuiFuncionalidadUrlImagen { get; set; }

    public string? GuiFuncionalidadUrlFormulario { get; set; }

    public string? GuiFuncionalidadTargetUrl { get; set; }

    public string? GuiFuncionalidadUrl { get; set; }

    public string? GuiFuncionalidadToolTip { get; set; }

    public bool GuiFuncionalidadEsMenu { get; set; }

    public string? GuiFuncionalidadNombreControl { get; set; }

    public string? GuiFuncionalidadNombreComando { get; set; }

    public int GuiFuncionalidadOrden { get; set; }

    public int GuiFuncionalidadIdFuncionalidad { get; set; }

    public int GuiFuncionalidadIdTipoFuncionalidad { get; set; }

    public bool EsFormato { get; set; }

    public bool TieneGraficos { get; set; }

    public string Cabecera { get; set; } = null!;

    public int Orden { get; set; }

    public bool Basica { get; set; }

    public string Multiempresa { get; set; } = null!;
}
