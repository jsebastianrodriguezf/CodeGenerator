namespace SAMMAI.Transverse.Models.Objects;

public class SegUsuarioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Usuario { get; set; } = null!;
    public string? UsuarioCodigo { get; set; }
    public int? IntentosFallidos { get; set; }
    public int? NumeroIngresos { get; set; }
    public DateTime? FechaUltimoIngresoFh { get; set; }
    public DateTime? FechaIntentoFallidoFh { get; set; }
    public string? Clave { get; set; }
    public string? Nombre { get; set; }
    public string? Profesion { get; set; }
    public string Email { get; set; } = null!;
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public decimal? CostoHora { get; set; }
    public double? PorcentajeComision { get; set; }
    public bool? AccesoActivo { get; set; }
    public bool? CambiarClave { get; set; }
    public DateTime? FechaUltimoCambioClaveFh { get; set; }
    public bool AplicaRecargo { get; set; }
    public bool Sexo { get; set; }
    public int IdPerfil { get; set; }
    public int IdCargo { get; set; }
    public int IdGrupo { get; set; }
    public int IdZona { get; set; }
    public string? Identificacion { get; set; }
    public int IdUsuario { get; set; }
    public byte[]? Preferencias { get; set; }
    public bool Habilitado { get; set; }
    public string? IdDispositivo { get; set; }
}
