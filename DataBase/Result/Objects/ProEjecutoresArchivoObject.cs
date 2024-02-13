namespace SAMMAI.Transverse.Models.Objects;

public class ProEjecutoresArchivoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EjecutoresArchivo { get; set; } = null!;
    public bool? Revisado { get; set; }
    public bool? Aprobado { get; set; }
    public DateTime? FechaRevision { get; set; }
    public DateTime? FechaAprobacion { get; set; }
    public int IdArchivo { get; set; }
    public int IdEjecutores { get; set; }
}
