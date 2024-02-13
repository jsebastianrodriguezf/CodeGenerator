namespace SAMMAI.Transverse.Models.Objects;

public class ProHorarioProyectoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string HorarioProyecto { get; set; } = null!;
    public string? HorarioProyectoCodigo { get; set; }
    public int IdDocumentoProyecto { get; set; }
    public string? Lunes { get; set; }
    public string? Martes { get; set; }
    public string? Miercoles { get; set; }
    public string? Jueves { get; set; }
    public string? Viernes { get; set; }
    public string? Sabado { get; set; }
    public string? Domingo { get; set; }
    public string? Festivos { get; set; }
}
