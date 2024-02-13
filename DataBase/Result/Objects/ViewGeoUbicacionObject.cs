namespace SAMMAI.Transverse.Models.Objects;

public class ViewGeoUbicacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string? Ubicacion { get; set; }
    public string? UbicacionCodigo { get; set; }
    public string? Tabla { get; set; }
    public int? IdObjeto { get; set; }
    public double? Longitud { get; set; }
    public double? Latitud { get; set; }
    public DateTime? FechaFh { get; set; }
    public string Multiempresa { get; set; } = null!;
}
