namespace SAMMAI.Transverse.Models.Objects;

public class OrtReporteTecnicoFallaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ReporteTecnicoFalla { get; set; } = null!;
    public int IdReporteTecnico { get; set; }
    public int IdFalla { get; set; }
    public int IdFallaCausa { get; set; }
    public int IdFallaEfecto { get; set; }
}
