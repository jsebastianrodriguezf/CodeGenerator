using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDisMotivoEvento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string MotivoEvento { get; set; } = null!;

    public string? MotivoEventoCodigo { get; set; }

    public bool ResponsableServicio { get; set; }

    public bool VaradaProduccion { get; set; }

    public bool EsFalla { get; set; }

    public string Multiempresa { get; set; } = null!;
}
