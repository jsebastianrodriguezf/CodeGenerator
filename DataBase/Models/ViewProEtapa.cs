using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProEtapa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Etapa { get; set; } = null!;

    public string? EtapaCodigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Orden { get; set; }

    public int? Completado { get; set; }

    public double? PorcentajePresupuesto { get; set; }

    public decimal? ValorPresupuesto { get; set; }

    public DateTime FechaInicioPlaneadaFf { get; set; }

    public DateTime? FechaInicioProyectadaFf { get; set; }

    public DateTime? FechaInicioRealFf { get; set; }

    public DateTime FechaFinPlaneadaFf { get; set; }

    public DateTime? FechaFinProyectadaFf { get; set; }

    public DateTime? FechaFinRealFf { get; set; }

    public string Multiempresa { get; set; } = null!;
}
