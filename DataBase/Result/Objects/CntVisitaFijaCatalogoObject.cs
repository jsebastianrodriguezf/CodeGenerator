namespace SAMMAI.Transverse.Models.Objects;

public class CntVisitaFijaCatalogoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string VisitaFijaCatalogo { get; set; } = null!;
    public double Cantidad { get; set; }
    public double Precio { get; set; }
    public int IdVisitaFija { get; set; }
    public int IdCatalogo { get; set; }
}
