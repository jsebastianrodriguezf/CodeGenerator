namespace SAMMAI.Transverse.Models.Objects;

public class GasDetalleGastoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleGasto { get; set; } = null!;
    public string? DetalleGastoCodigo { get; set; }
    public DateTime FechaFf { get; set; }
    public double Valor { get; set; }
    public double Cantidad { get; set; }
    public int IdGasto { get; set; }
    public int IdCatalogo { get; set; }
    public int IdDocumentoGasto { get; set; }
}
