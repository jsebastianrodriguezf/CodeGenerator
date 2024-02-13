namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenRegistroEnvioObject
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
    public string GenEnvioCorreoEnvioCorreo { get; set; } = null!;
    public string? GenEnvioCorreoEnvioCorreoCodigo { get; set; }
    public int GenEnvioCorreoEstrategia { get; set; }
    public string GenEnvioCorreoTabla { get; set; } = null!;
    public int GenEnvioCorreoIdReporte { get; set; }
    public string? GenEnvioCorreoCorreoAdicional { get; set; }
    public string? GenEnvioCorreoPlantillaAdjunto { get; set; }
    public int GenEnvioCorreoIdSubtipoDocumento { get; set; }
    public int GenEnvioCorreoIdEstadoTipoDocumento { get; set; }
    public int GenEnvioCorreoCantidadMensajes { get; set; }
    public int GenEnvioCorreoTiempoPorMensajes { get; set; }
    public int IdRegistroEnvio { get; set; }
    public string GenRegistroEnvioPadreRegistroEnvio { get; set; } = null!;
    public string? GenRegistroEnvioPadreRegistroEnvioCodigo { get; set; }
    public string GenRegistroEnvioPadreTabla { get; set; } = null!;
    public bool GenRegistroEnvioPadreReintentar { get; set; }
    public int GenRegistroEnvioPadreIdEnvioCorreo { get; set; }
    public int GenRegistroEnvioPadreIdRegistroEnvio { get; set; }
    public string Multiempresa { get; set; } = null!;
}
