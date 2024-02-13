namespace SAMMAI.Transverse.Models.Objects;

public class EquEquipoObject
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
    public DateTime? UltimaLecturaFh { get; set; }
    public double HorometroActual { get; set; }
    public double PromedioHoras { get; set; }
    public decimal? Costo { get; set; }
    public DateTime? FechaImportacionFf { get; set; }
    public string? GarantiaCancelada { get; set; }
    public int IdCatalogoEquipo { get; set; }
    public int IdSistema { get; set; }
    public int IdSucursal { get; set; }
    public int IdZona { get; set; }
    public int IdVersionEquipo { get; set; }
    public int IdTerceroComprador { get; set; }
    public int IdTercero { get; set; }
    public int IdTerceroServicio { get; set; }
    public int IdEquipo { get; set; }
    public int IdEstadoEquipo { get; set; }
    public int IdCentroCosto { get; set; }
}
