using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisEventoEstadoEvento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EventoEstadoEvento { get; set; } = null!;

    public int IdEvento { get; set; }

    public int IdEstadoEvento { get; set; }

    public DateTime FechaHoraRegistroFh { get; set; }

    public bool AfectaCliente { get; set; }

    public int IdSistema { get; set; }

    public virtual DisEstadoEvento IdEstadoEventoNavigation { get; set; } = null!;

    public virtual DisEvento IdEventoNavigation { get; set; } = null!;

    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
}
