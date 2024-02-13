namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocPreguntumObject
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
    public string DocEvaluacionEvaluacion { get; set; } = null!;
    public string? DocEvaluacionEvaluacionCodigo { get; set; }
    public bool DocEvaluacionActiva { get; set; }
    public int DocEvaluacionIdSubtipoDocumento { get; set; }
    public string Multiempresa { get; set; } = null!;
}
