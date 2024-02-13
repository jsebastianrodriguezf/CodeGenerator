namespace SAMMAI.Transverse.Models.Objects;

public class DocTareaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Tarea { get; set; } = null!;
    public string? TareaCodigo { get; set; }
    public int IdCatalogo { get; set; }
    public int IdCargo { get; set; }
    public DateTime FechaPlaneadaFh { get; set; }
    public int PorcentajeAvance { get; set; }
    public int IdDocumento { get; set; }
}
