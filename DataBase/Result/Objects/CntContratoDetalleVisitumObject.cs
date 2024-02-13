namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoDetalleVisitumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoDetalleVisita { get; set; } = null!;
    public string? ContratoDetalleVisitaCodigo { get; set; }
    public int Frecuencia { get; set; }
    public double? CadaN { get; set; }
    public int Dia { get; set; }
    public int Estrategia { get; set; }
    public bool PorTrabajo { get; set; }
    public bool IncluirMenores { get; set; }
    public int AproximarA { get; set; }
    public DateTime FechaFf { get; set; }
    public int IdContrato { get; set; }
    public int DiaHabil { get; set; }
    public DateTime? FechaInactivaInicialFf { get; set; }
    public DateTime? FechaInactivaFinalFf { get; set; }
}
