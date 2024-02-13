namespace SAMMAI.Transverse.Models.Objects;

public class SegRegistroPeticionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string RegistroPeticion { get; set; } = null!;
    public string? RegistroPeticionCodigo { get; set; }
    public string UrlServicio { get; set; } = null!;
    public string Modulo { get; set; } = null!;
    public string Aplicacion { get; set; } = null!;
    public bool EsExitosa { get; set; }
    public string? MensajeRespuesta { get; set; }
    public int IdUsuario { get; set; }
    public double? TamanoPeticion { get; set; }
}
