namespace SAMMAI.Transverse.Models.Objects;

public class EquCicloHorometroObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string CicloHorometro { get; set; } = null!;
    public string? CicloHorometroCodigo { get; set; }
    public int IdEquipo { get; set; }
    public double HorometroInicial { get; set; }
    public double HorometroFinal { get; set; }
    public bool AfectarProyeccion { get; set; }
    public bool ReparacionMayor { get; set; }
    public bool ReiniciarHorometro { get; set; }
    public int Nciclo { get; set; }
}
