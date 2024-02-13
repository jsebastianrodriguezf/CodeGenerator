using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisEvento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Evento { get; set; } = null!;

    public string? EventoCodigo { get; set; }

    public DateTime FechaHoraInicioFf { get; set; }

    public DateTime DuracionHh { get; set; }

    public bool AfectaProduccion { get; set; }

    public string? Notas { get; set; }

    public int IdEquipo { get; set; }

    public int IdMotivoEvento { get; set; }

    public int IdUsuario { get; set; }

    public int IdEstadoEquipo { get; set; }

    public int IdFalla { get; set; }

    public int IdFallaCausa { get; set; }

    public int IdMetodoDeteccion { get; set; }

    public DateTime FechaHoraEstimadaFh { get; set; }

    public int EventoTipo { get; set; }

    public bool AfectaCliente { get; set; }

    public int IdEstadoEvento { get; set; }

    public string? Codigo { get; set; }

    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();

    public virtual ICollection<DisEventoCatalogo> DisEventoCatalogos { get; set; } = new List<DisEventoCatalogo>();

    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();

    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual EquEstadoEquipo IdEstadoEquipoNavigation { get; set; } = null!;

    public virtual DisEstadoEvento IdEstadoEventoNavigation { get; set; } = null!;

    public virtual EquFalla IdFallaCausaNavigation { get; set; } = null!;

    public virtual EquFalla IdFallaNavigation { get; set; } = null!;

    public virtual DisMetodoDeteccion IdMetodoDeteccionNavigation { get; set; } = null!;

    public virtual DisMotivoEvento IdMotivoEventoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
