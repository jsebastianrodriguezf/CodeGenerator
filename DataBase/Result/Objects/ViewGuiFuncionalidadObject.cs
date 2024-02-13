namespace SAMMAI.Transverse.Models.Objects;

public class ViewGuiFuncionalidadObject
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
    public string GuiFuncionalidadPadreFuncionalidad { get; set; } = null!;
    public string? GuiFuncionalidadPadreFuncionalidadCodigo { get; set; }
    public string? GuiFuncionalidadPadreUrlImagen { get; set; }
    public string? GuiFuncionalidadPadreUrlFormulario { get; set; }
    public string? GuiFuncionalidadPadreTargetUrl { get; set; }
    public string? GuiFuncionalidadPadreUrl { get; set; }
    public string? GuiFuncionalidadPadreToolTip { get; set; }
    public bool GuiFuncionalidadPadreEsMenu { get; set; }
    public string? GuiFuncionalidadPadreNombreControl { get; set; }
    public string? GuiFuncionalidadPadreNombreComando { get; set; }
    public int GuiFuncionalidadPadreOrden { get; set; }
    public int GuiFuncionalidadPadreIdFuncionalidad { get; set; }
    public int GuiFuncionalidadPadreIdTipoFuncionalidad { get; set; }
    public bool? GuiFuncionalidadPadreEsMvc { get; set; }
    public int GuiFuncionalidadPadreIdAplicacion { get; set; }
    public int IdTipoFuncionalidad { get; set; }
    public string GuiTipoFuncionalidadTipoFuncionalidad { get; set; } = null!;
    public string? GuiTipoFuncionalidadTipoFuncionalidadCodigo { get; set; }
    public bool? EsMvc { get; set; }
    public int IdAplicacion { get; set; }
    public string GuiAplicacionAplicacion { get; set; } = null!;
    public string? GuiAplicacionAplicacionCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
