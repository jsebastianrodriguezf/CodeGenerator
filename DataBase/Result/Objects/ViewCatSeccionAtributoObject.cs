namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatSeccionAtributoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SeccionAtributo { get; set; } = null!;
    public string? SeccionAtributoCodigo { get; set; }
    public int Orden { get; set; }
    public int IdUsoSeccionAtributo { get; set; }
    public string CatUsoSeccionAtributoUsoSeccionAtributo { get; set; } = null!;
    public string? CatUsoSeccionAtributoUsoSeccionAtributoCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
