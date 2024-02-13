namespace SAMMAI.Transverse.Models.Objects;

public class ViewLicLicenciaParametroObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string LicenciaParametro { get; set; } = null!;
    public int IdLicencia { get; set; }
    public string LicLicenciaLicencia { get; set; } = null!;
    public string? LicLicenciaLicenciaCodigo { get; set; }
    public string LicLicenciaSerial { get; set; } = null!;
    public string LicLicenciaClave { get; set; } = null!;
    public DateTime LicLicenciaFechaInicioFf { get; set; }
    public DateTime LicLicenciaFechaFinFf { get; set; }
    public int LicLicenciaIdTercero { get; set; }
    public int LicLicenciaIdCatalogo { get; set; }
    public int IdParametro { get; set; }
    public string LicParametroParametro { get; set; } = null!;
    public string? LicParametroParametroCodigo { get; set; }
    public string LicParametroDescripcion { get; set; } = null!;
    public string Valor { get; set; } = null!;
    public bool EsParteSerial { get; set; }
    public string Multiempresa { get; set; } = null!;
}
