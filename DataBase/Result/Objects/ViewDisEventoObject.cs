namespace SAMMAI.Transverse.Models.Objects;

public class ViewDisEventoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Evento { get; set; } = null!;
    public string? EventoCodigo { get; set; }
    public DateTime FechaHoraInicioFf { get; set; }
    public DateTime DuracionHh { get; set; }
    public bool AfectaProduccion { get; set; }
    public string? Notas { get; set; }
    public int IdEquipo { get; set; }
    public string EquEquipoEquipo { get; set; } = null!;
    public string? EquEquipoEquipoCodigo { get; set; }
    public string EquEquipoEquipoSerial { get; set; } = null!;
    public string? EquEquipoNombreContacto { get; set; }
    public string? EquEquipoTelefonoContacto { get; set; }
    public string? EquEquipoUbicacion { get; set; }
    public string? EquEquipoObservaciones { get; set; }
    public DateTime? EquEquipoFechaPuestaMarchaFh { get; set; }
    public DateTime? EquEquipoVencimientoGarantiaFabricaFf { get; set; }
    public DateTime? EquEquipoVencimientoGarantiaDistribuidorFf { get; set; }
    public double? EquEquipoHorasGarantia { get; set; }
    public DateTime? EquEquipoUltimaLecturaFh { get; set; }
    public double EquEquipoHorometroActual { get; set; }
    public double EquEquipoPromedioHoras { get; set; }
    public decimal? EquEquipoCosto { get; set; }
    public DateTime? EquEquipoFechaImportacionFf { get; set; }
    public string? EquEquipoGarantiaCancelada { get; set; }
    public int EquEquipoIdCatalogoEquipo { get; set; }
    public int EquEquipoIdSistema { get; set; }
    public int EquEquipoIdSucursal { get; set; }
    public int EquEquipoIdZona { get; set; }
    public int EquEquipoIdVersionEquipo { get; set; }
    public int EquEquipoIdTerceroComprador { get; set; }
    public int EquEquipoIdTercero { get; set; }
    public int EquEquipoIdTerceroServicio { get; set; }
    public int EquEquipoIdEquipo { get; set; }
    public int EquEquipoIdEstadoEquipo { get; set; }
    public int IdMotivoEvento { get; set; }
    public string DisMotivoEventoMotivoEvento { get; set; } = null!;
    public string? DisMotivoEventoMotivoEventoCodigo { get; set; }
    public bool DisMotivoEventoResponsableServicio { get; set; }
    public bool DisMotivoEventoVaradaProduccion { get; set; }
    public bool DisMotivoEventoEsFalla { get; set; }
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
    public int IdEstadoEquipo { get; set; }
    public string EquEstadoEquipoEstadoEquipo { get; set; } = null!;
    public string? EquEstadoEquipoEstadoEquipoCodigo { get; set; }
    public bool EquEstadoEquipoActivo { get; set; }
    public int IdFalla { get; set; }
    public string EquFallaFalla { get; set; } = null!;
    public string? EquFallaFallaCodigo { get; set; }
    public string EquFallaProcedimiento { get; set; } = null!;
    public int EquFallaIdTipoFalla { get; set; }
    public int EquFallaIdFalla { get; set; }
    public int IdFallaCausa { get; set; }
    public string EquFallaCausaFalla { get; set; } = null!;
    public string? EquFallaCausaFallaCodigo { get; set; }
    public string EquFallaCausaProcedimiento { get; set; } = null!;
    public int EquFallaCausaIdTipoFalla { get; set; }
    public int EquFallaCausaIdFalla { get; set; }
    public int IdMetodoDeteccion { get; set; }
    public string DisMetodoDeteccionMetodoDeteccion { get; set; } = null!;
    public string? DisMetodoDeteccionMetodoDeteccionCodigo { get; set; }
    public DateTime FechaHoraEstimadaFh { get; set; }
    public int EventoTipo { get; set; }
    public bool AfectaCliente { get; set; }
    public int IdEstadoEvento { get; set; }
    public string DisEstadoEventoEstadoEvento { get; set; } = null!;
    public string? DisEstadoEventoEstadoEventoCodigo { get; set; }
    public string? Codigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
