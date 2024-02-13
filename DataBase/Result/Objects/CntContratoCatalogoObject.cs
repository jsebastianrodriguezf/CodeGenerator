namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoCatalogo { get; set; } = null!;
    public double? Incluida { get; set; }
    public double? Consumida { get; set; }
    public double? Saldo { get; set; }
    public decimal? PrecioVenta { get; set; }
    public string? Notas { get; set; }
    public int IdContrato { get; set; }
    public int IdCatalogo { get; set; }
}
