using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGuiAyudum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Ayuda { get; set; } = null!;

    public string? AyudaCodigo { get; set; }

    public int IdAyuda { get; set; }

    public string GuiAyudaPadreAyuda { get; set; } = null!;

    public string? GuiAyudaPadreAyudaCodigo { get; set; }

    public int GuiAyudaPadreIdAyuda { get; set; }

    public string Multiempresa { get; set; } = null!;
}
