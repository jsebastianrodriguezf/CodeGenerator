namespace SAMMAI.Transverse.Models.Objects;

public class CatTarifaCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TarifaCatalogo { get; set; } = null!;
    public string? TarifaCatalogoCodigo { get; set; }
    public int IdCatalogoTarifa { get; set; }
    public int IdCatalogoElemento { get; set; }
    public int IdTipotarifa { get; set; }
}
