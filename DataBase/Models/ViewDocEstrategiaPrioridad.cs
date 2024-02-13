using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocEstrategiaPrioridad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstrategiaPrioridad { get; set; } = null!;

    public string? EstrategiaPrioridadCodigo { get; set; }

    public DateTime LunesIniHh { get; set; }

    public DateTime LunesFinHh { get; set; }

    public DateTime MartesIniHh { get; set; }

    public DateTime MartesFinHh { get; set; }

    public DateTime MiercolesIniHh { get; set; }

    public DateTime MiercolesFinHh { get; set; }

    public DateTime JuevesIniHh { get; set; }

    public DateTime JuevesFinHh { get; set; }

    public DateTime ViernesIniHh { get; set; }

    public DateTime ViernesFinHh { get; set; }

    public DateTime SabadoIniHh { get; set; }

    public DateTime SabadoFinHh { get; set; }

    public DateTime DomingoIniHh { get; set; }

    public DateTime DomingoFinHh { get; set; }

    public DateTime FestivoIniHh { get; set; }

    public DateTime FestivoFinHh { get; set; }

    public string Multiempresa { get; set; } = null!;
}
