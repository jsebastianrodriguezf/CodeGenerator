namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenAccesosSammObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string AccesosSamm { get; set; } = null!;
    public string? AccesosSammCodigo { get; set; }
    public string DireccionIp { get; set; } = null!;
    public bool EsHijo { get; set; }
    public bool EsSalida { get; set; }
    public bool Edita { get; set; }
    public string Multiempresa { get; set; } = null!;
}
