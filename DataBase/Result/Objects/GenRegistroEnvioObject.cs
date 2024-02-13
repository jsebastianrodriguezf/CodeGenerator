namespace SAMMAI.Transverse.Models.Objects;

public class GenRegistroEnvioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string RegistroEnvio { get; set; } = null!;
    public string? RegistroEnvioCodigo { get; set; }
    public string Tabla { get; set; } = null!;
    public bool Reintentar { get; set; }
    public int IdEnvioCorreo { get; set; }
    public int IdRegistroEnvio { get; set; }
}
