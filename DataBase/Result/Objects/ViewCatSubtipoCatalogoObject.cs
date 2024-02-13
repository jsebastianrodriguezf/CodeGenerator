namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatSubtipoCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SubtipoCatalogo { get; set; } = null!;
    public string? SubtipoCatalogoCodigo { get; set; }
    public int IdTipoCatalogo { get; set; }
    public string CatTipoCatalogoTipoCatalogo { get; set; } = null!;
    public string? CatTipoCatalogoTipoCatalogoCodigo { get; set; }
    public bool CatTipoCatalogoAfectaInventario { get; set; }
    public bool CatTipoCatalogoAfectaProduccion { get; set; }
    public string Multiempresa { get; set; } = null!;
}
