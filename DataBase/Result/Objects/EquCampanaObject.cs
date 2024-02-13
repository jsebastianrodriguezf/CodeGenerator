namespace SAMMAI.Transverse.Models.Objects;

public class EquCampanaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Campana { get; set; } = null!;
    public string? CampanaCodigo { get; set; }
    public string DetalleCampana { get; set; } = null!;
    public DateTime FechaInicioFf { get; set; }
    public DateTime FechafinFf { get; set; }
    public bool Activo { get; set; }
    public int IdTercero { get; set; }
    public int IdCatalogoTempario { get; set; }
}
