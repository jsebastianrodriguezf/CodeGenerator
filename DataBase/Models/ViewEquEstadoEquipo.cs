using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquEstadoEquipo
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

    public string Multiempresa { get; set; } = null!;
}
