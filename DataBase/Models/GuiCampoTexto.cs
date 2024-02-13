using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GuiCampoTexto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CampoTexto { get; set; } = null!;

    public string? CampoTextoCodigo { get; set; }

    public bool EsHtml { get; set; }

    public int IdFuncionalidad { get; set; }

    public virtual ICollection<GuiTextoDefecto> GuiTextoDefectos { get; set; } = new List<GuiTextoDefecto>();

    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;
}
