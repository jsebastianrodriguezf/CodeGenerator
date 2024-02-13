using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenMonedum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Moneda { get; set; } = null!;

    public string? MonedaCodigo { get; set; }

    public string Abreviatura { get; set; } = null!;

    public double Cambio { get; set; }

    public string Multiempresa { get; set; } = null!;
}
