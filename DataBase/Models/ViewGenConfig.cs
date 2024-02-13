using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenConfig
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Config { get; set; } = null!;

    public string? ConfigCodigo { get; set; }

    public string Modulo { get; set; } = null!;

    public string? Valor { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? IdObjeto { get; set; }

    public string Multiempresa { get; set; } = null!;
}
