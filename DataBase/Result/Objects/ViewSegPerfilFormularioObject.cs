namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegPerfilFormularioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PerfilFormulario { get; set; } = null!;
    public int IdPerfil { get; set; }
    public string SegPerfilPerfil { get; set; } = null!;
    public string? SegPerfilPerfilCodigo { get; set; }
    public string? SegPerfilDescripcion { get; set; }
    public bool? SegPerfilMostrarBotones { get; set; }
    public bool? SegPerfilParaCliente { get; set; }
    public bool? SegPerfilParaProveedor { get; set; }
    public int IdFormulario { get; set; }
    public string GenFormularioFormulario { get; set; } = null!;
    public string? GenFormularioFormularioCodigo { get; set; }
    public int GenFormularioDuplicar { get; set; }
    public int GenFormularioEliminarIntermedias { get; set; }
    public string Multiempresa { get; set; } = null!;
}
