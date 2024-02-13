namespace SAMMAI.Transverse.Models.Objects;

public class OrtProgramacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Programacion { get; set; } = null!;
    public string? ProgramacionCodigo { get; set; }
    public DateTime? DesdeFh { get; set; }
    public double? Duracion { get; set; }
    public string? Comentario { get; set; }
    public int IdUsuario { get; set; }
    public int IdTipoProgramacion { get; set; }
    public int IdMotivoCancelacion { get; set; }
    public int IdDocumentoOt { get; set; }
    public int IdProgramacion { get; set; }
    public int IdReporteTecnico { get; set; }
    public int IdCatalogoActividad { get; set; }
    public double Costo { get; set; }
    public int IdSoporteItemDocumento { get; set; }
}
