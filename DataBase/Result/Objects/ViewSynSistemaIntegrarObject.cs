namespace SAMMAI.Transverse.Models.Objects;

public class ViewSynSistemaIntegrarObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SistemaIntegrar { get; set; } = null!;
    public string? SistemaIntegrarCodigo { get; set; }
    public string? Usuario { get; set; }
    public string? Clave { get; set; }
    public string? UrlAutenticar { get; set; }
    public int IdTipoAutenticacion { get; set; }
    public string SynTipoAutenticacionTipoAutenticacion { get; set; } = null!;
    public string? SynTipoAutenticacionTipoAutenticacionCodigo { get; set; }
    public string? Token { get; set; }
    public string? MetodoAutenticar { get; set; }
    public string? EstructuraResponseAutenticar { get; set; }
    public string Multiempresa { get; set; } = null!;
}
