namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntCorrimientoVisitaFijaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CorrimientoVisitaFija { get; set; } = null!;
    public string? CorrimientoVisitaFijaCodigo { get; set; }
    public DateTime FechaOriginalFf { get; set; }
    public int IdVisitaFija { get; set; }
    public string CntVisitaFijaVisitaFija { get; set; } = null!;
    public string? CntVisitaFijaVisitaFijaCodigo { get; set; }
    public DateTime CntVisitaFijaFechaFf { get; set; }
    public DateTime CntVisitaFijaFechaCreadaFf { get; set; }
    public double? CntVisitaFijaHorometro { get; set; }
    public int CntVisitaFijaIdDocumentoOt { get; set; }
    public int CntVisitaFijaIdContratoEquipo { get; set; }
    public int CntVisitaFijaIdContratoDetalleVisita { get; set; }
    public int CntVisitaFijaIdCatalogoTempario { get; set; }
    public bool? CntVisitaFijaEsPorTrabajo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
