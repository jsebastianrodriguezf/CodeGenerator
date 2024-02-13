namespace SAMMAI.Transverse.Models.Objects;

public class GenConfiguracionAtributoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ConfiguracionAtributos { get; set; } = null!;
    public string? ConfiguracionAtributosCodigo { get; set; }
    public int Orden { get; set; }
    public bool EsObligatorio { get; set; }
    public bool EsResaltado { get; set; }
    public string Defecto { get; set; } = null!;
    public int IdAtributo { get; set; }
    public int IdFormulario { get; set; }
    public int? IdTablaResultado { get; set; }
    public int? IdTablaRelacion { get; set; }
}
