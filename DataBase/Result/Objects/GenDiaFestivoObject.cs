namespace SAMMAI.Transverse.Models.Objects;

public class GenDiaFestivoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DiaFestivo { get; set; } = null!;
    public string? DiaFestivoCodigo { get; set; }
    public DateTime? FechaFf { get; set; }
}
