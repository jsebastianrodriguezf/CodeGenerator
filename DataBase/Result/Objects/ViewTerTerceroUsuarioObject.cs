namespace SAMMAI.Transverse.Models.Objects;

public class ViewTerTerceroUsuarioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TerceroUsuario { get; set; } = null!;
    public int IdTercero { get; set; }
    public string TerTerceroTercero { get; set; } = null!;
    public string? TerTerceroTerceroCodigo { get; set; }
    public string TerTerceroTerceroNit { get; set; } = null!;
    public string? TerTerceroDireccion { get; set; }
    public string? TerTerceroContacto { get; set; }
    public string TerTerceroTelefono { get; set; } = null!;
    public string? TerTerceroFax { get; set; }
    public string? TerTerceroEmail { get; set; }
    public string? TerTerceroWebsite { get; set; }
    public string? TerTerceroRepresentante { get; set; }
    public string? TerTerceroNotas { get; set; }
    public string TerTerceroTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroEsCliente { get; set; }
    public bool TerTerceroEsProveedor { get; set; }
    public bool TerTerceroEsTransportador { get; set; }
    public bool TerTerceroEsFabricante { get; set; }
    public bool TerTerceroEsEmpresaPropia { get; set; }
    public string? TerTerceroClasificacion { get; set; }
    public int TerTerceroIdZona { get; set; }
    public int TerTerceroIdEstadoTercero { get; set; }
    public int TerTerceroIdNaturalezaTercero { get; set; }
    public bool TerTerceroEsProspecto { get; set; }
    public int IdUsuario { get; set; }
    public string SegUsuarioUsuario { get; set; } = null!;
    public string? SegUsuarioUsuarioCodigo { get; set; }
    public int? SegUsuarioIntentosFallidos { get; set; }
    public int? SegUsuarioNumeroIngresos { get; set; }
    public DateTime? SegUsuarioFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioClave { get; set; }
    public string? SegUsuarioNombre { get; set; }
    public string? SegUsuarioProfesion { get; set; }
    public string SegUsuarioEmail { get; set; } = null!;
    public string? SegUsuarioDireccion { get; set; }
    public string? SegUsuarioTelefono { get; set; }
    public decimal? SegUsuarioCostoHora { get; set; }
    public double? SegUsuarioPorcentajeComision { get; set; }
    public bool? SegUsuarioAccesoActivo { get; set; }
    public bool? SegUsuarioCambiarClave { get; set; }
    public DateTime? SegUsuarioFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioAplicaRecargo { get; set; }
    public bool SegUsuarioSexo { get; set; }
    public int SegUsuarioIdPerfil { get; set; }
    public int SegUsuarioIdCargo { get; set; }
    public int SegUsuarioIdGrupo { get; set; }
    public int SegUsuarioIdZona { get; set; }
    public string? SegUsuarioIdentificacion { get; set; }
    public int SegUsuarioIdUsuario { get; set; }
    public byte[]? SegUsuarioPreferencias { get; set; }
    public bool SegUsuarioHabilitado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
