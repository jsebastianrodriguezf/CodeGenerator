namespace SAMMAI.Transverse.Models.Objects;

public class CatPosicionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Posicion { get; set; } = null!;
    public string? PosicionCodigo { get; set; }
    public int IdCatalogoEquipoEquipo { get; set; }
    public int IdCatalogoEquipoComponente { get; set; }
    public int IdDimensionX { get; set; }
    public int IdDimensionY { get; set; }
    public int IdDimensionZ { get; set; }
}
