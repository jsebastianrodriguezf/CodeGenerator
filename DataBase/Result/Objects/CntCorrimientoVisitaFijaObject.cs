namespace SAMMAI.Transverse.Models.Objects;

public class CntCorrimientoVisitaFijaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CorrimientoVisitaFija { get; set; } = null!;
    public string? CorrimientoVisitaFijaCodigo { get; set; }
    public DateTime FechaOriginalFf { get; set; }
    public int IdVisitaFija { get; set; }
}
