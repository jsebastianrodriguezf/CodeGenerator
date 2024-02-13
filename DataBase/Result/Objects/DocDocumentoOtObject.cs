namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoOtObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoOt { get; set; } = null!;
    public string MotivoServicio { get; set; } = null!;
    public bool EnTaller { get; set; }
    public string? DiagnosticoInicial { get; set; }
    public string Contacto { get; set; } = null!;
    public string? Cargo { get; set; }
    public string Telefono { get; set; } = null!;
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? DireccionUbicacion { get; set; }
    public double DuracionEstimada { get; set; }
    public DateTime? FechaGarantiaFf { get; set; }
    public DateTime FechaCompromisoFh { get; set; }
    public string? Trabajos { get; set; }
    public string? Recomendaciones { get; set; }
    public string? Compromisos { get; set; }
    public string? ReclamacionFabrica { get; set; }
    public double? PorcentajeCliente { get; set; }
    public double? PorcentajeDistribuidor { get; set; }
    public double? PorcentajeFabricante { get; set; }
    public bool? SegunTempario { get; set; }
    public bool? DistribuyeCentros { get; set; }
    public int IdTipoServicio { get; set; }
    public int IdEquipo { get; set; }
    public int IdUsuarioCoordinador { get; set; }
    public int IdMotivoCancelacion { get; set; }
    public int IdSucursal { get; set; }
    public int IdSistema { get; set; }
    public int IdDepartamentoSolicitud { get; set; }
    public int IdContrato { get; set; }
    public int IdZona { get; set; }
}
