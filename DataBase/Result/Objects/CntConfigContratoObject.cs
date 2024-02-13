namespace SAMMAI.Transverse.Models.Objects;

public class CntConfigContratoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ConfigContrato { get; set; } = null!;
    public int? IdContratoEquipo { get; set; }
    public int? IdCatalogoTempario { get; set; }
    public int? IdTerceroProveedor { get; set; }
    public int? Frecuencia { get; set; }
    public double? CadaN { get; set; }
    public int? Dia { get; set; }
    public int? Estrategia { get; set; }
    public bool? PorTrabajo { get; set; }
    public bool? IncluirMenores { get; set; }
    public int? AproximarA { get; set; }
    public DateTime? FechaFf { get; set; }
    public int? DiaHabil { get; set; }
}
