namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Contrato { get; set; } = null!;
    public string? ContratoCodigo { get; set; }
    public string Numero { get; set; } = null!;
    public decimal? TotalContrato { get; set; }
    public decimal? Presupuesto { get; set; }
    public DateTime FechaInicioFf { get; set; }
    public DateTime? FechaFinFf { get; set; }
    public int? DiasCumplimiento { get; set; }
    public string? Condiciones { get; set; }
    public int IdPeriodoContrato { get; set; }
    public int IdTercero { get; set; }
    public int IdTipoServicio { get; set; }
    public int IdTipoContrato { get; set; }
    public int IdTerceroServicio { get; set; }
    public int IdSubtipoDocumento { get; set; }
    public int IdDepartamentoSolicitud { get; set; }
    public int IdUsuarioCoordinador { get; set; }
    public int IdDocumentoAlquiler { get; set; }
    public int IdEstadoTipoDocumentoInicial { get; set; }
    public int IdSubtipoDocumentoSolicitud { get; set; }
}
