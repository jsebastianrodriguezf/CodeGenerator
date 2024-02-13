namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoBodegaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoBodega { get; set; } = null!;
    public double Disponible { get; set; }
    public double Existencia { get; set; }
    public double Reservado { get; set; }
    public double ExistenciaMinima { get; set; }
    public double? EnOrdenes { get; set; }
    public string? Localizacion { get; set; }
    public decimal Costo { get; set; }
    public double? ExistenciaMaxima { get; set; }
    public int IdCatalogo { get; set; }
    public int IdBodega { get; set; }
}
