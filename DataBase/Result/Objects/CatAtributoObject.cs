namespace SAMMAI.Transverse.Models.Objects;

public class CatAtributoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Atributo { get; set; } = null!;
    public string? AtributoCodigo { get; set; }
    public string NombreControl { get; set; } = null!;
    public bool EsVariable { get; set; }
    public bool Resaltado { get; set; }
    public double? ValorMinimo { get; set; }
    public double? ValorMaximo { get; set; }
    public int IdSeccionAtributo { get; set; }
    public int IdTipoAtributo { get; set; }
    public int IdUnidad { get; set; }
    public bool EsObligatorio { get; set; }
}
