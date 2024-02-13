namespace SAMMAI.Transverse.Models.Objects;

public class ViewTerSucursalObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Sucursal { get; set; } = null!;
    public string? SucursalCodigo { get; set; }
    public string? Contacto { get; set; }
    public string Telefono { get; set; } = null!;
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? Direccion { get; set; }
    public bool ParaVenta { get; set; }
    public bool ParaSoporte { get; set; }
    public bool ParaAlquiler { get; set; }
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
    public int IdZona { get; set; }
    public string GenZonaZona { get; set; } = null!;
    public string? GenZonaZonaCodigo { get; set; }
    public double? GenZonaTiempoDesplazamiento { get; set; }
    public int GenZonaNivel { get; set; }
    public int GenZonaIdZona { get; set; }
    public string? GenZonaCodigoExterno { get; set; }
    public int IdUsuarioAsesor { get; set; }
    public string SegUsuarioAsesorUsuario { get; set; } = null!;
    public string? SegUsuarioAsesorUsuarioCodigo { get; set; }
    public int? SegUsuarioAsesorIntentosFallidos { get; set; }
    public int? SegUsuarioAsesorNumeroIngresos { get; set; }
    public DateTime? SegUsuarioAsesorFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioAsesorFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioAsesorClave { get; set; }
    public string? SegUsuarioAsesorNombre { get; set; }
    public string? SegUsuarioAsesorProfesion { get; set; }
    public string SegUsuarioAsesorEmail { get; set; } = null!;
    public string? SegUsuarioAsesorDireccion { get; set; }
    public string? SegUsuarioAsesorTelefono { get; set; }
    public decimal? SegUsuarioAsesorCostoHora { get; set; }
    public double? SegUsuarioAsesorPorcentajeComision { get; set; }
    public bool? SegUsuarioAsesorAccesoActivo { get; set; }
    public bool? SegUsuarioAsesorCambiarClave { get; set; }
    public DateTime? SegUsuarioAsesorFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioAsesorAplicaRecargo { get; set; }
    public bool SegUsuarioAsesorSexo { get; set; }
    public int SegUsuarioAsesorIdPerfil { get; set; }
    public int SegUsuarioAsesorIdCargo { get; set; }
    public int SegUsuarioAsesorIdGrupo { get; set; }
    public int SegUsuarioAsesorIdZona { get; set; }
    public string? SegUsuarioAsesorIdentificacion { get; set; }
    public int SegUsuarioAsesorIdUsuario { get; set; }
    public byte[]? SegUsuarioAsesorPreferencias { get; set; }
    public bool SegUsuarioAsesorHabilitado { get; set; }
    public int IdUsuarioTecnico { get; set; }
    public string SegUsuarioTecnicoUsuario { get; set; } = null!;
    public string? SegUsuarioTecnicoUsuarioCodigo { get; set; }
    public int? SegUsuarioTecnicoIntentosFallidos { get; set; }
    public int? SegUsuarioTecnicoNumeroIngresos { get; set; }
    public DateTime? SegUsuarioTecnicoFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioTecnicoFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioTecnicoClave { get; set; }
    public string? SegUsuarioTecnicoNombre { get; set; }
    public string? SegUsuarioTecnicoProfesion { get; set; }
    public string SegUsuarioTecnicoEmail { get; set; } = null!;
    public string? SegUsuarioTecnicoDireccion { get; set; }
    public string? SegUsuarioTecnicoTelefono { get; set; }
    public decimal? SegUsuarioTecnicoCostoHora { get; set; }
    public double? SegUsuarioTecnicoPorcentajeComision { get; set; }
    public bool? SegUsuarioTecnicoAccesoActivo { get; set; }
    public bool? SegUsuarioTecnicoCambiarClave { get; set; }
    public DateTime? SegUsuarioTecnicoFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioTecnicoAplicaRecargo { get; set; }
    public bool SegUsuarioTecnicoSexo { get; set; }
    public int SegUsuarioTecnicoIdPerfil { get; set; }
    public int SegUsuarioTecnicoIdCargo { get; set; }
    public int SegUsuarioTecnicoIdGrupo { get; set; }
    public int SegUsuarioTecnicoIdZona { get; set; }
    public string? SegUsuarioTecnicoIdentificacion { get; set; }
    public int SegUsuarioTecnicoIdUsuario { get; set; }
    public byte[]? SegUsuarioTecnicoPreferencias { get; set; }
    public bool SegUsuarioTecnicoHabilitado { get; set; }
    public int IdSucursal { get; set; }
    public string TerSucursalPadreSucursal { get; set; } = null!;
    public string? TerSucursalPadreSucursalCodigo { get; set; }
    public string? TerSucursalPadreContacto { get; set; }
    public string TerSucursalPadreTelefono { get; set; } = null!;
    public string? TerSucursalPadreFax { get; set; }
    public string? TerSucursalPadreEmail { get; set; }
    public string? TerSucursalPadreDireccion { get; set; }
    public bool TerSucursalPadreParaVenta { get; set; }
    public bool TerSucursalPadreParaSoporte { get; set; }
    public bool TerSucursalPadreParaAlquiler { get; set; }
    public int TerSucursalPadreIdTercero { get; set; }
    public int TerSucursalPadreIdZona { get; set; }
    public int TerSucursalPadreIdUsuarioAsesor { get; set; }
    public int TerSucursalPadreIdUsuarioTecnico { get; set; }
    public int TerSucursalPadreIdSucursal { get; set; }
    public int TerSucursalPadreIdEstadoTercero { get; set; }
    public string? TerSucursalPadreCodigorecursiva { get; set; }
    public string TerSucursalPadreCargo { get; set; } = null!;
    public int IdEstadoTercero { get; set; }
    public string TerEstadoTerceroEstadoTercero { get; set; } = null!;
    public string? TerEstadoTerceroEstadoTerceroCodigo { get; set; }
    public string? Codigorecursiva { get; set; }
    public string Cargo { get; set; } = null!;
    public string Multiempresa { get; set; } = null!;
}
