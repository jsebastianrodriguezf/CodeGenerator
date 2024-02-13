namespace SAMMAI.Transverse.Models.Objects;

public class CatReemplazoCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ReemplazoCatalogoEquipo { get; set; } = null!;
    public int IdReemplazo { get; set; }
    public int IdVersionEquipo { get; set; }
    public int IdCatalogoEquipo { get; set; }
}
