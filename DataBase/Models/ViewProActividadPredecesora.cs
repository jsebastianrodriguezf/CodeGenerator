using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProActividadPredecesora
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ActividadPredecesora { get; set; } = null!;

    public string? ActividadPredecesoraCodigo { get; set; }

    public int IdActividadOrigen { get; set; }

    public string ProActividadOrigenActividad { get; set; } = null!;

    public string? ProActividadOrigenActividadCodigo { get; set; }

    public string ProActividadOrigenDescripcionDetallada { get; set; } = null!;

    public DateTime ProActividadOrigenFechainicioPlaneada { get; set; }

    public DateTime ProActividadOrigenFechainicioProyectada { get; set; }

    public DateTime ProActividadOrigenFechaInicioReal { get; set; }

    public string ProActividadOrigenDuracion { get; set; } = null!;

    public DateTime ProActividadOrigenFechaTerminacionPlaneada { get; set; }

    public DateTime ProActividadOrigenFechaTerminacionProyectada { get; set; }

    public DateTime ProActividadOrigenFechaTerminacionReal { get; set; }

    public int IdActividadDestino { get; set; }

    public string ProActividadDestinoActividad { get; set; } = null!;

    public string? ProActividadDestinoActividadCodigo { get; set; }

    public string ProActividadDestinoDescripcionDetallada { get; set; } = null!;

    public DateTime ProActividadDestinoFechainicioPlaneada { get; set; }

    public DateTime ProActividadDestinoFechainicioProyectada { get; set; }

    public DateTime ProActividadDestinoFechaInicioReal { get; set; }

    public string ProActividadDestinoDuracion { get; set; } = null!;

    public DateTime ProActividadDestinoFechaTerminacionPlaneada { get; set; }

    public DateTime ProActividadDestinoFechaTerminacionProyectada { get; set; }

    public DateTime ProActividadDestinoFechaTerminacionReal { get; set; }

    public string Multiempresa { get; set; } = null!;
}
