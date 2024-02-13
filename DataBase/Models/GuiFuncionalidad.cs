using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GuiFuncionalidad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Funcionalidad { get; set; } = null!;

    public string? FuncionalidadCodigo { get; set; }

    public string? UrlImagen { get; set; }

    public string? UrlFormulario { get; set; }

    public string? TargetUrl { get; set; }

    public string? Url { get; set; }

    public string? ToolTip { get; set; }

    public bool EsMenu { get; set; }

    public string? NombreControl { get; set; }

    public string? NombreComando { get; set; }

    public int Orden { get; set; }

    public int IdFuncionalidad { get; set; }

    public int IdTipoFuncionalidad { get; set; }

    public bool? EsMvc { get; set; }

    public int IdAplicacion { get; set; }

    public virtual ICollection<GuiCampoTexto> GuiCampoTextos { get; set; } = new List<GuiCampoTexto>();

    public virtual GuiAplicacion IdAplicacionNavigation { get; set; } = null!;

    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;

    public virtual GuiTipoFuncionalidad IdTipoFuncionalidadNavigation { get; set; } = null!;

    public virtual ICollection<GuiFuncionalidad> InverseIdFuncionalidadNavigation { get; set; } = new List<GuiFuncionalidad>();

    public virtual ICollection<RepReporte> RepReportes { get; set; } = new List<RepReporte>();

    public virtual ICollection<SegPerfilFuncionalidad> SegPerfilFuncionalidads { get; set; } = new List<SegPerfilFuncionalidad>();
}
