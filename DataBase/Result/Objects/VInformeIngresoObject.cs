namespace SAMMAI.Transverse.Models.Objects;

public class VInformeIngresoObject
{
    public int Id { get; set; }
    public string? Encabezado { get; set; }
    public string Cuerpo { get; set; } = null!;
    public string? Email { get; set; }
}
