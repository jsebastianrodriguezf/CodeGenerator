namespace SAMMAI.Transverse.Models.Objects;

public class GenDetalleRegistroEnvioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleRegistroEnvio { get; set; } = null!;
    public string? DetalleRegistroEnvioCodigo { get; set; }
    public string Email { get; set; } = null!;
    public bool Enviado { get; set; }
    public bool Enviar { get; set; }
    public int IdObjeto { get; set; }
    public int IdRegistroEnvio { get; set; }
}
