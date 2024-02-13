using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class AlqHistoricoAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string HistoricoAlquiler { get; set; } = null!;

    public string? HistoricoAlquilerCodigo { get; set; }

    public DateTime FechaEstado { get; set; }

    public int? IdEquipo { get; set; }

    public int? IdEstadoEquipo { get; set; }

    public int? IdDocumento { get; set; }

    public virtual DocDocumento? IdDocumentoNavigation { get; set; }

    public virtual EquEquipo? IdEquipoNavigation { get; set; }

    public virtual EquEstadoEquipo? IdEstadoEquipoNavigation { get; set; }
}
