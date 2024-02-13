namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoEquipo { get; set; } = null!;
    public int? GarantiaMeses { get; set; }
    public int? GarantiaHoras { get; set; }
    public bool ManejaHorometro { get; set; }
    public int IdMarca { get; set; }
}
