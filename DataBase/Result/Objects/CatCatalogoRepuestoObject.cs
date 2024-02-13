namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoRepuestoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoRepuesto { get; set; } = null!;
    public int? GarantiaDias { get; set; }
    public int? GarantiaHoras { get; set; }
    public bool Vigente { get; set; }
    public int IdMarca { get; set; }
    public double? Peso { get; set; }
}
