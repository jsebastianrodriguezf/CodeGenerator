namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoProyectoEntregableObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoProyectoEntregable { get; set; } = null!;
    public int IdDocumentoProyecto { get; set; }
    public int IdEntregable { get; set; }
}
