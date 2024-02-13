namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoProyectoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoProyecto { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicioEstimada { get; set; }
    public DateTime FechaFinEstimada { get; set; }
    public string? Descripcion { get; set; }
    public decimal? Presupuesto { get; set; }
}
