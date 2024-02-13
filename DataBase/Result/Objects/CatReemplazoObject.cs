namespace SAMMAI.Transverse.Models.Objects;

public class CatReemplazoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Reemplazo { get; set; } = null!;
    public string? ReemplazoCodigo { get; set; }
    public int IdTipoReemplazo { get; set; }
    public int IdCatalogoRepuesto { get; set; }
    public int IdCatalogoRepuesto1 { get; set; }
}
