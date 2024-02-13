namespace SAMMAI.Transverse.Models.Objects;

public class GenFormularioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Formulario { get; set; } = null!;
    public string? FormularioCodigo { get; set; }
    public int Duplicar { get; set; }
    public int EliminarIntermedias { get; set; }
}
