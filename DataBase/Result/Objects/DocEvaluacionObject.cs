namespace SAMMAI.Transverse.Models.Objects;

public class DocEvaluacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Evaluacion { get; set; } = null!;
    public string? EvaluacionCodigo { get; set; }
    public bool Activa { get; set; }
    public int IdSubtipoDocumento { get; set; }
}
