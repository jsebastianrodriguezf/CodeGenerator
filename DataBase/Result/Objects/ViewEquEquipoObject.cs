namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Equipo { get; set; } = null!;
    public string? EquipoCodigo { get; set; }
    public string EquipoSerial { get; set; } = null!;
    public string? NombreContacto { get; set; }
    public string? TelefonoContacto { get; set; }
    public string? Ubicacion { get; set; }
    public string? Observaciones { get; set; }
    public DateTime? FechaPuestaMarchaFh { get; set; }
    public DateTime? VencimientoGarantiaFabricaFf { get; set; }
    public DateTime? VencimientoGarantiaDistribuidorFf { get; set; }
    public double? HorasGarantia { get; set; }
    public double? HorometroActual { get; set; }
    public DateTime? UltimaLecturaFh { get; set; }
    public double PromedioHoras { get; set; }
    public decimal? Costo { get; set; }
    public DateTime? FechaImportacionFf { get; set; }
    public string? GarantiaCancelada { get; set; }
    public int IdCatalogoEquipo { get; set; }
    public string CatCatalogoEquipoCatalogoEquipo { get; set; } = null!;
    public int? CatCatalogoEquipoGarantiaMeses { get; set; }
    public int? CatCatalogoEquipoGarantiaHoras { get; set; }
    public bool CatCatalogoEquipoManejaHorometro { get; set; }
    public int CatCatalogoEquipoIdMarca { get; set; }
    public string CatSubtipocatalogoSubtipocatalogo { get; set; } = null!;
    public string? CatCatalogoEquipoCatalogoCodigo { get; set; }
    public string CatCatalogoEquipoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoEquipoPrecioVenta { get; set; }
    public int? CatCatalogoEquipoTiempoConsecucion { get; set; }
    public bool CatCatalogoEquipoEsNacional { get; set; }
    public int CatCatalogoEquipoIdFamilia { get; set; }
    public int CatCatalogoEquipoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public bool CatCatalogoEquipoBloquearCostear { get; set; }
    public int IdSistema { get; set; }
    public string CatSistemaSistema { get; set; } = null!;
    public string? CatSistemaSistemaCodigo { get; set; }
    public int CatSistemaIdSistema { get; set; }
    public int IdSucursal { get; set; }
    public string TerSucursalSucursal { get; set; } = null!;
    public string? TerSucursalSucursalCodigo { get; set; }
    public string? TerSucursalContacto { get; set; }
    public string TerSucursalTelefono { get; set; } = null!;
    public string? TerSucursalFax { get; set; }
    public string? TerSucursalEmail { get; set; }
    public string? TerSucursalDireccion { get; set; }
    public bool TerSucursalParaVenta { get; set; }
    public bool TerSucursalParaSoporte { get; set; }
    public bool TerSucursalParaAlquiler { get; set; }
    public int TerSucursalIdTercero { get; set; }
    public int TerSucursalIdZona { get; set; }
    public int TerSucursalIdUsuarioAsesor { get; set; }
    public int TerSucursalIdUsuarioTecnico { get; set; }
    public int TerSucursalIdSucursal { get; set; }
    public int TerSucursalIdEstadoTercero { get; set; }
    public string? TerSucursalCodigorecursiva { get; set; }
    public string TerSucursalCargo { get; set; } = null!;
    public int IdZona { get; set; }
    public string GenZonaZona { get; set; } = null!;
    public string? GenZonaZonaCodigo { get; set; }
    public double? GenZonaTiempoDesplazamiento { get; set; }
    public int GenZonaNivel { get; set; }
    public int GenZonaIdZona { get; set; }
    public string? GenZonaCodigoExterno { get; set; }
    public int IdVersionEquipo { get; set; }
    public string CatVersionEquipoVersionEquipo { get; set; } = null!;
    public string? CatVersionEquipoVersionEquipoCodigo { get; set; }
    public int CatVersionEquipoIdCatalogoEquipo { get; set; }
    public int IdTerceroComprador { get; set; }
    public string TerTerceroCompradorTercero { get; set; } = null!;
    public string? TerTerceroCompradorTerceroCodigo { get; set; }
    public string TerTerceroCompradorTerceroNit { get; set; } = null!;
    public string? TerTerceroCompradorDireccion { get; set; }
    public string? TerTerceroCompradorContacto { get; set; }
    public string TerTerceroCompradorTelefono { get; set; } = null!;
    public string? TerTerceroCompradorFax { get; set; }
    public string? TerTerceroCompradorEmail { get; set; }
    public string? TerTerceroCompradorWebsite { get; set; }
    public string? TerTerceroCompradorRepresentante { get; set; }
    public string? TerTerceroCompradorNotas { get; set; }
    public string TerTerceroCompradorTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroCompradorEsCliente { get; set; }
    public bool TerTerceroCompradorEsProveedor { get; set; }
    public bool TerTerceroCompradorEsTransportador { get; set; }
    public bool TerTerceroCompradorEsFabricante { get; set; }
    public bool TerTerceroCompradorEsEmpresaPropia { get; set; }
    public string? TerTerceroCompradorClasificacion { get; set; }
    public int TerTerceroCompradorIdZona { get; set; }
    public int TerTerceroCompradorIdEstadoTercero { get; set; }
    public int TerTerceroCompradorIdNaturalezaTercero { get; set; }
    public bool TerTerceroCompradorEsProspecto { get; set; }
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
    public int IdTerceroServicio { get; set; }
    public string TerTerceroServicioTercero { get; set; } = null!;
    public string? TerTerceroServicioTerceroCodigo { get; set; }
    public string TerTerceroServicioTerceroNit { get; set; } = null!;
    public string? TerTerceroServicioDireccion { get; set; }
    public string? TerTerceroServicioContacto { get; set; }
    public string TerTerceroServicioTelefono { get; set; } = null!;
    public string? TerTerceroServicioFax { get; set; }
    public string? TerTerceroServicioEmail { get; set; }
    public string? TerTerceroServicioWebsite { get; set; }
    public string? TerTerceroServicioRepresentante { get; set; }
    public string? TerTerceroServicioNotas { get; set; }
    public string TerTerceroServicioTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroServicioEsCliente { get; set; }
    public bool TerTerceroServicioEsProveedor { get; set; }
    public bool TerTerceroServicioEsTransportador { get; set; }
    public bool TerTerceroServicioEsFabricante { get; set; }
    public bool TerTerceroServicioEsEmpresaPropia { get; set; }
    public string? TerTerceroServicioClasificacion { get; set; }
    public int TerTerceroServicioIdZona { get; set; }
    public int TerTerceroServicioIdEstadoTercero { get; set; }
    public int TerTerceroServicioIdNaturalezaTercero { get; set; }
    public bool TerTerceroServicioEsProspecto { get; set; }
    public int IdEquipo { get; set; }
    public string EquEquipoPadreEquipo { get; set; } = null!;
    public string? EquEquipoPadreEquipoCodigo { get; set; }
    public string EquEquipoPadreEquipoSerial { get; set; } = null!;
    public string? EquEquipoPadreNombreContacto { get; set; }
    public string? EquEquipoPadreTelefonoContacto { get; set; }
    public string? EquEquipoPadreUbicacion { get; set; }
    public string? EquEquipoPadreObservaciones { get; set; }
    public DateTime? EquEquipoPadreFechaPuestaMarchaFh { get; set; }
    public DateTime? EquEquipoPadreVencimientoGarantiaFabricaFf { get; set; }
    public DateTime? EquEquipoPadreVencimientoGarantiaDistribuidorFf { get; set; }
    public double? EquEquipoPadreHorasGarantia { get; set; }
    public DateTime? EquEquipoPadreUltimaLecturaFh { get; set; }
    public double EquEquipoPadreHorometroActual { get; set; }
    public double EquEquipoPadrePromedioHoras { get; set; }
    public decimal? EquEquipoPadreCosto { get; set; }
    public DateTime? EquEquipoPadreFechaImportacionFf { get; set; }
    public string? EquEquipoPadreGarantiaCancelada { get; set; }
    public int EquEquipoPadreIdCatalogoEquipo { get; set; }
    public int EquEquipoPadreIdSistema { get; set; }
    public int EquEquipoPadreIdSucursal { get; set; }
    public int EquEquipoPadreIdZona { get; set; }
    public int EquEquipoPadreIdVersionEquipo { get; set; }
    public int EquEquipoPadreIdTerceroComprador { get; set; }
    public int EquEquipoPadreIdTercero { get; set; }
    public int EquEquipoPadreIdTerceroServicio { get; set; }
    public int EquEquipoPadreIdEquipo { get; set; }
    public int EquEquipoPadreIdEstadoEquipo { get; set; }
    public int EquEquipoPadreIdCentroCosto { get; set; }
    public int IdEstadoEquipo { get; set; }
    public string EquEstadoEquipoEstadoEquipo { get; set; } = null!;
    public string? EquEstadoEquipoEstadoEquipoCodigo { get; set; }
    public bool EquEstadoEquipoActivo { get; set; }
    public int IdCentroCosto { get; set; }
    public string DocCentroCostoCentroCosto { get; set; } = null!;
    public string? DocCentroCostoCentroCostoCodigo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
