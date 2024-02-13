namespace SAMMAI.Transverse.Models.Objects;

public class GuiFuncionalidadObject
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
}
