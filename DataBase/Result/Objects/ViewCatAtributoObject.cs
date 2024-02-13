namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatAtributoObject
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
    public string CatSeccionAtributoSeccionAtributo { get; set; } = null!;
    public string? CatSeccionAtributoSeccionAtributoCodigo { get; set; }
    public int CatSeccionAtributoOrden { get; set; }
    public int CatSeccionAtributoIdUsoSeccionAtributo { get; set; }
    public int IdTipoAtributo { get; set; }
    public string EquTipoAtributoTipoAtributo { get; set; } = null!;
    public string? EquTipoAtributoTipoAtributoCodigo { get; set; }
    public string EquTipoAtributoPrefijoControl { get; set; } = null!;
    public int IdUnidad { get; set; }
    public string GenUnidadUnidad { get; set; } = null!;
    public string? GenUnidadUnidadCodigo { get; set; }
    public bool EsObligatorio { get; set; }
    public string Multiempresa { get; set; } = null!;
}
