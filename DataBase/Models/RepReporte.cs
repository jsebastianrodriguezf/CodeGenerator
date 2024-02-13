using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class RepReporte
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

    public bool EsFormato { get; set; }

    public bool TieneGraficos { get; set; }

    public string Cabecera { get; set; } = null!;

    public int Orden { get; set; }

    public bool Basica { get; set; }

    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();

    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;

    public virtual ICollection<RepCampoReporte> RepCampoReportes { get; set; } = new List<RepCampoReporte>();

    public virtual ICollection<RepIndicador> RepIndicadors { get; set; } = new List<RepIndicador>();

    public virtual ICollection<RepOpcionReporte> RepOpcionReportes { get; set; } = new List<RepOpcionReporte>();

    public virtual ICollection<RepOrigenDato> RepOrigenDatos { get; set; } = new List<RepOrigenDato>();

    public virtual ICollection<RepReporteCategorium> RepReporteCategoria { get; set; } = new List<RepReporteCategorium>();
}
