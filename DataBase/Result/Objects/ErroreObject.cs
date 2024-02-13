namespace SAMMAI.Transverse.Models.Objects;

public class ErroreObject
{
    public DateTime FechaModificacion { get; set; }
    public string? Error { get; set; }
    public string? ErrorCodigo { get; set; }
    public string? Seguimiento { get; set; }
    public string? Version { get; set; }
    public string? Cliente { get; set; }
    public int? IdUsuarioModifico { get; set; }
}
