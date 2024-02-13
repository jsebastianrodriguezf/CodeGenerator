namespace SAMMAI.Transverse.Models.Objects;

public class GenZonaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Zona { get; set; } = null!;
    public string? ZonaCodigo { get; set; }
    public double? TiempoDesplazamiento { get; set; }
    public int Nivel { get; set; }
    public int IdZona { get; set; }
    public string? CodigoExterno { get; set; }
}
