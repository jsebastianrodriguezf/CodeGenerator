namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoEvaluacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoEvaluacion { get; set; } = null!;
    public string PersonaEncuestada { get; set; } = null!;
    public DateTime FechaEncuestaFf { get; set; }
    public int IdDocumento { get; set; }
    public int IdEvaluacion { get; set; }
    public string Observaciones { get; set; } = null!;
}
