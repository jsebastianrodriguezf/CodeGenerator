namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoOtroObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoOtro { get; set; } = null!;
    public decimal Costo { get; set; }
    public int? PeriodoAlquiler { get; set; }
}
