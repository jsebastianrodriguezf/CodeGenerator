namespace SAMMAI.Transverse.Models.Objects;

public class GenBodegaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Bodega { get; set; } = null!;
    public string? BodegaCodigo { get; set; }
    public bool SalidasEnRojo { get; set; }
    public bool UsaLocalizacion { get; set; }
    public int? IdSucursal { get; set; }
}
