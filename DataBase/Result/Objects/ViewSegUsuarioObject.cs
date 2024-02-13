namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegUsuarioObject
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
    public string SegPerfilPerfil { get; set; } = null!;
    public string? SegPerfilPerfilCodigo { get; set; }
    public string? SegPerfilDescripcion { get; set; }
    public bool? SegPerfilMostrarBotones { get; set; }
    public bool? SegPerfilParaCliente { get; set; }
    public bool? SegPerfilParaProveedor { get; set; }
    public int IdCargo { get; set; }
    public string SegCargoCargo { get; set; } = null!;
    public string? SegCargoCargoCodigo { get; set; }
    public bool? SegCargoEsTecnico { get; set; }
    public bool? SegCargoEsComercial { get; set; }
    public bool? SegCargoEsCoordinador { get; set; }
    public decimal? SegCargoValorHora { get; set; }
    public bool SegCargoEsAdministrativo { get; set; }
    public int IdGrupo { get; set; }
    public string SegGrupoGrupo { get; set; } = null!;
    public string? SegGrupoGrupoCodigo { get; set; }
    public bool SegGrupoActivo { get; set; }
    public int IdZona { get; set; }
    public string GenZonaZona { get; set; } = null!;
    public string? GenZonaZonaCodigo { get; set; }
    public double? GenZonaTiempoDesplazamiento { get; set; }
    public int GenZonaNivel { get; set; }
    public int GenZonaIdZona { get; set; }
    public string? GenZonaCodigoExterno { get; set; }
    public string? Identificacion { get; set; }
    public int IdUsuario { get; set; }
    public string SegUsuarioPadreUsuario { get; set; } = null!;
    public string? SegUsuarioPadreUsuarioCodigo { get; set; }
    public int? SegUsuarioPadreIntentosFallidos { get; set; }
    public int? SegUsuarioPadreNumeroIngresos { get; set; }
    public DateTime? SegUsuarioPadreFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioPadreFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioPadreClave { get; set; }
    public string? SegUsuarioPadreNombre { get; set; }
    public string? SegUsuarioPadreProfesion { get; set; }
    public string SegUsuarioPadreEmail { get; set; } = null!;
    public string? SegUsuarioPadreDireccion { get; set; }
    public string? SegUsuarioPadreTelefono { get; set; }
    public decimal? SegUsuarioPadreCostoHora { get; set; }
    public double? SegUsuarioPadrePorcentajeComision { get; set; }
    public bool? SegUsuarioPadreAccesoActivo { get; set; }
    public bool? SegUsuarioPadreCambiarClave { get; set; }
    public DateTime? SegUsuarioPadreFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioPadreAplicaRecargo { get; set; }
    public bool SegUsuarioPadreSexo { get; set; }
    public int SegUsuarioPadreIdPerfil { get; set; }
    public int SegUsuarioPadreIdCargo { get; set; }
    public int SegUsuarioPadreIdGrupo { get; set; }
    public int SegUsuarioPadreIdZona { get; set; }
    public string? SegUsuarioPadreIdentificacion { get; set; }
    public int SegUsuarioPadreIdUsuario { get; set; }
    public byte[]? SegUsuarioPadrePreferencias { get; set; }
    public bool SegUsuarioPadreHabilitado { get; set; }
    public string? SegUsuarioPadreIdDispositivo { get; set; }
    public byte[]? Preferencias { get; set; }
    public bool Habilitado { get; set; }
    public string? IdDispositivo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
