namespace SAMMAI.Transverse.Models.Objects;

public class ProEjecutoreObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Ejecutores { get; set; } = null!;
    public string? EjecutoresCodigo { get; set; }
    public double Costo { get; set; }
    public string UnidadTiempo { get; set; } = null!;
    public int IdHorarioTrabajo { get; set; }
    public int IdUsuario { get; set; }
    public int IdHorarioEjecutores { get; set; }
}
