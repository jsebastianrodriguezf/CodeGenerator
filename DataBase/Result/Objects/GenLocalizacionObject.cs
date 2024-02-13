namespace SAMMAI.Transverse.Models.Objects;

public class GenLocalizacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Localizacion { get; set; } = null!;
    public string? LocalizacionCodigo { get; set; }
    public int IdCatalogoBodega { get; set; }
    public int Existencia { get; set; }
    public int ExistenciaMaxima { get; set; }
}
