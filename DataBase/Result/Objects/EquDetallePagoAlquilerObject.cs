namespace SAMMAI.Transverse.Models.Objects;

public class EquDetallePagoAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetallePagoAlquiler { get; set; } = null!;
    public string? DetallePagoAlquilerCodigo { get; set; }
    public decimal Valor { get; set; }
    public double? Horometro { get; set; }
    public int IdPagoAlquiler { get; set; }
    public int IdEquipo { get; set; }
    public double? ValorMulta { get; set; }
    public bool Facturado { get; set; }
    public DateTime? FechaInicialFf { get; set; }
    public DateTime? FechaFinFf { get; set; }
    public int? IdDocumento { get; set; }
    public int IdItemDocumento { get; set; }
}
