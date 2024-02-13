namespace SAMMAI.Transverse.Models.Objects;

public class EquOverhallObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Overhall { get; set; } = null!;
    public string? OverhallCodigo { get; set; }
    public double Horometro { get; set; }
    public DateTime FechaFf { get; set; }
    public int IdEquipo { get; set; }
    public int IdDocumentoOt { get; set; }
}
