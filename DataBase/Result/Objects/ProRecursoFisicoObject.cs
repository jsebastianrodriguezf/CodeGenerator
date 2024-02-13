namespace SAMMAI.Transverse.Models.Objects;

public class ProRecursoFisicoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string RecursoFisico { get; set; } = null!;
    public string? RecursoFisicoCodigo { get; set; }
    public double Costo { get; set; }
    public string UnidadTiempo { get; set; } = null!;
    public bool EsPropio { get; set; }
    public int IdEquipo { get; set; }
    public int IdCatalogo { get; set; }
}
