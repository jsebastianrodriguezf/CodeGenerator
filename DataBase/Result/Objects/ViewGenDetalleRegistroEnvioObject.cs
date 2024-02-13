namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenDetalleRegistroEnvioObject
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
    public int IdRegistroEnvio { get; set; }
    public string GenRegistroEnvioRegistroEnvio { get; set; } = null!;
    public string? GenRegistroEnvioRegistroEnvioCodigo { get; set; }
    public string GenRegistroEnvioTabla { get; set; } = null!;
    public bool GenRegistroEnvioReintentar { get; set; }
    public int GenRegistroEnvioIdEnvioCorreo { get; set; }
    public int GenRegistroEnvioIdRegistroEnvio { get; set; }
    public int IdObjeto { get; set; }
    public string Multiempresa { get; set; } = null!;
}
