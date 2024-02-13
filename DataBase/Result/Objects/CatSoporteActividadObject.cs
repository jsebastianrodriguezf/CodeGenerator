namespace SAMMAI.Transverse.Models.Objects;

public class CatSoporteActividadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SoporteActividad { get; set; } = null!;
    public string? SoporteActividadCodigo { get; set; }
    public double Duracion { get; set; }
    public int IdDetalleTempario { get; set; }
    public int IdCargo { get; set; }
}
