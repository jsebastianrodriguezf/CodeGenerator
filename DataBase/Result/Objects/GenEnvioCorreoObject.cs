namespace SAMMAI.Transverse.Models.Objects;

public class GenEnvioCorreoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EnvioCorreo { get; set; } = null!;
    public string? EnvioCorreoCodigo { get; set; }
    public int Estrategia { get; set; }
    public string Tabla { get; set; } = null!;
    public int IdReporte { get; set; }
    public string? CorreoAdicional { get; set; }
    public string? PlantillaAdjunto { get; set; }
    public int IdSubtipoDocumento { get; set; }
    public int IdEstadoTipoDocumento { get; set; }
    public int CantidadMensajes { get; set; }
    public int TiempoPorMensajes { get; set; }
    public int CantidadReintento { get; set; }
    public int? AdjuntarArchivo { get; set; }
    public int? IdRemitenteCorreo { get; set; }
}
