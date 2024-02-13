namespace SAMMAI.Transverse.Models.Objects;

public class CatCatalogoTemparioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CatalogoTempario { get; set; } = null!;
    public double? DuracionEstimada { get; set; }
    public bool EnTaller { get; set; }
    public bool EsCiclico { get; set; }
    public bool DetieneEquipos { get; set; }
    public double? HorasDetencion { get; set; }
    public int PeriodoHoras { get; set; }
    public bool FacturaTodo { get; set; }
    public int PeriodoDias { get; set; }
    public double PorcGarantia { get; set; }
    public double PorcTropicalizacion { get; set; }
    public int IdTipoServicio { get; set; }
    public bool Proyectar { get; set; }
    public bool IncluirMenores { get; set; }
    public int ModoAjuste { get; set; }
}
