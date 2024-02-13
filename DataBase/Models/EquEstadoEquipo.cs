using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquEstadoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EstadoEquipo { get; set; } = null!;

    public string? EstadoEquipoCodigo { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; } = new List<AlqHistoricoAlquiler>();

    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();

    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
}
