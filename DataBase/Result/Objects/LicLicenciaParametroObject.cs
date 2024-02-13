namespace SAMMAI.Transverse.Models.Objects;

public class LicLicenciaParametroObject
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
    public int IdParametro { get; set; }
    public string Valor { get; set; } = null!;
    public bool EsParteSerial { get; set; }
}
