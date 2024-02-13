using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GuiAyudum
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

    public virtual GuiAyudum IdAyudaNavigation { get; set; } = null!;

    public virtual ICollection<GuiAyudum> InverseIdAyudaNavigation { get; set; } = new List<GuiAyudum>();
}
