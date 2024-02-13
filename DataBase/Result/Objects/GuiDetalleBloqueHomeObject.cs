namespace SAMMAI.Transverse.Models.Objects;

public class GuiDetalleBloqueHomeObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleBloqueHome { get; set; } = null!;
    public string? DetalleBloqueHomeCodigo { get; set; }
    public int IdBloqueHome { get; set; }
    public int? TipoCampo { get; set; }
    public int? Orden { get; set; }
    public int? TipoBloqueHome { get; set; }
    public int? EstrategiaFecha { get; set; }
    public int? ItemsTab { get; set; }
    public int? PosicionTab { get; set; }
    public int OrdenResultados { get; set; }
}
