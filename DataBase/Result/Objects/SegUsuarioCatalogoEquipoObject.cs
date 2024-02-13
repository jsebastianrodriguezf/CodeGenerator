namespace SAMMAI.Transverse.Models.Objects;

public class SegUsuarioCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string UsuarioCatalogoEquipo { get; set; } = null!;
    public int IdUsuario { get; set; }
    public int IdTipoServicio { get; set; }
    public int IdCatalogoEquipo { get; set; }
}
