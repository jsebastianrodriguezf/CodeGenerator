namespace SAMMAI.Transverse.Models.Objects;

public class DocPreguntumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Pregunta { get; set; } = null!;
    public string? PreguntaCodigo { get; set; }
    public int Orden { get; set; }
    public bool Activa { get; set; }
    public int Valor { get; set; }
    public int IdEvaluacion { get; set; }
}
