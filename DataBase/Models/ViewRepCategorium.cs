using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewRepCategorium
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Categoria { get; set; } = null!;

    public string? CategoriaCodigo { get; set; }

    public int IdCategoria { get; set; }

    public string RepCategoriaPadreCategoria { get; set; } = null!;

    public string? RepCategoriaPadreCategoriaCodigo { get; set; }

    public int RepCategoriaPadreIdCategoria { get; set; }

    public string Multiempresa { get; set; } = null!;
}
