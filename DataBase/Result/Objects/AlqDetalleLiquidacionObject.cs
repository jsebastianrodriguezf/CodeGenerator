namespace SAMMAI.Transverse.Models.Objects;

public class AlqDetalleLiquidacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleLiquidacion { get; set; } = null!;
    public string? DetalleLiquidacionCodigo { get; set; }
    public int? Cantidad { get; set; }
    public int? Dias { get; set; }
    public DateTime? FechaInicioFh { get; set; }
    public DateTime? FechaFinFh { get; set; }
    public int? IdItemDocumento { get; set; }
    public int? IdDetalleAlquiler { get; set; }
    public int? Saldo { get; set; }
    public int? IdDocumentoMovimiento { get; set; }
    public double? Horometro { get; set; }
    public int? IdTarifa { get; set; }
    public int IdEvento { get; set; }
}
