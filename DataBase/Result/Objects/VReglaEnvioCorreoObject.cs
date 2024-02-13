namespace SAMMAI.Transverse.Models.Objects;

public class VReglaEnvioCorreoObject
{
    public int Id { get; set; }
    public string EnvioCorreo { get; set; } = null!;
    public int Estrategia { get; set; }
    public string? EnvioCorreoCodigo { get; set; }
    public string Tabla { get; set; } = null!;
    public int IdReporte { get; set; }
    public string? CorreoAdicional { get; set; }
    public string? PlantillaAdjunto { get; set; }
}
