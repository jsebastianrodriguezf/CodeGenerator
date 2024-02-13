namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenNotificacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Notificacion { get; set; } = null!;
    public string? NotificacionCodigo { get; set; }
    public int? IdTipoNotificacion { get; set; }
    public string GenTipoNotificacionTipoNotificacion { get; set; } = null!;
    public string? GenTipoNotificacionTipoNotificacionCodigo { get; set; }
    public int? IdUsuarioOrigen { get; set; }
    public string SegUsuarioOrigenUsuario { get; set; } = null!;
    public string? SegUsuarioOrigenUsuarioCodigo { get; set; }
    public int? SegUsuarioOrigenIntentosFallidos { get; set; }
    public int? SegUsuarioOrigenNumeroIngresos { get; set; }
    public DateTime? SegUsuarioOrigenFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioOrigenFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioOrigenClave { get; set; }
    public string? SegUsuarioOrigenNombre { get; set; }
    public string? SegUsuarioOrigenProfesion { get; set; }
    public string SegUsuarioOrigenEmail { get; set; } = null!;
    public string? SegUsuarioOrigenDireccion { get; set; }
    public string? SegUsuarioOrigenTelefono { get; set; }
    public decimal? SegUsuarioOrigenCostoHora { get; set; }
    public double? SegUsuarioOrigenPorcentajeComision { get; set; }
    public bool? SegUsuarioOrigenAccesoActivo { get; set; }
    public bool? SegUsuarioOrigenCambiarClave { get; set; }
    public DateTime? SegUsuarioOrigenFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioOrigenAplicaRecargo { get; set; }
    public bool SegUsuarioOrigenSexo { get; set; }
    public int SegUsuarioOrigenIdPerfil { get; set; }
    public int SegUsuarioOrigenIdCargo { get; set; }
    public int SegUsuarioOrigenIdGrupo { get; set; }
    public int SegUsuarioOrigenIdZona { get; set; }
    public string? SegUsuarioOrigenIdentificacion { get; set; }
    public int SegUsuarioOrigenIdUsuario { get; set; }
    public byte[]? SegUsuarioOrigenPreferencias { get; set; }
    public bool SegUsuarioOrigenHabilitado { get; set; }
    public string? SegUsuarioOrigenIdDispositivo { get; set; }
    public int? IdUsuarioDestino { get; set; }
    public string SegUsuarioDestinoUsuario { get; set; } = null!;
    public string? SegUsuarioDestinoUsuarioCodigo { get; set; }
    public int? SegUsuarioDestinoIntentosFallidos { get; set; }
    public int? SegUsuarioDestinoNumeroIngresos { get; set; }
    public DateTime? SegUsuarioDestinoFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioDestinoFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioDestinoClave { get; set; }
    public string? SegUsuarioDestinoNombre { get; set; }
    public string? SegUsuarioDestinoProfesion { get; set; }
    public string SegUsuarioDestinoEmail { get; set; } = null!;
    public string? SegUsuarioDestinoDireccion { get; set; }
    public string? SegUsuarioDestinoTelefono { get; set; }
    public decimal? SegUsuarioDestinoCostoHora { get; set; }
    public double? SegUsuarioDestinoPorcentajeComision { get; set; }
    public bool? SegUsuarioDestinoAccesoActivo { get; set; }
    public bool? SegUsuarioDestinoCambiarClave { get; set; }
    public DateTime? SegUsuarioDestinoFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioDestinoAplicaRecargo { get; set; }
    public bool SegUsuarioDestinoSexo { get; set; }
    public int SegUsuarioDestinoIdPerfil { get; set; }
    public int SegUsuarioDestinoIdCargo { get; set; }
    public int SegUsuarioDestinoIdGrupo { get; set; }
    public int SegUsuarioDestinoIdZona { get; set; }
    public string? SegUsuarioDestinoIdentificacion { get; set; }
    public int SegUsuarioDestinoIdUsuario { get; set; }
    public byte[]? SegUsuarioDestinoPreferencias { get; set; }
    public bool SegUsuarioDestinoHabilitado { get; set; }
    public string? SegUsuarioDestinoIdDispositivo { get; set; }
    public string? Datos { get; set; }
    public string Multiempresa { get; set; } = null!;
}
