namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegPerfilBloqueHomeObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PerfilBloqueHome { get; set; } = null!;
    public int IdPerfil { get; set; }
    public string SegPerfilPerfil { get; set; } = null!;
    public string? SegPerfilPerfilCodigo { get; set; }
    public string? SegPerfilDescripcion { get; set; }
    public bool? SegPerfilMostrarBotones { get; set; }
    public int IdBloqueHome { get; set; }
    public string GuiBloqueHomeBloqueHome { get; set; } = null!;
    public string? GuiBloqueHomeBloqueHomeCodigo { get; set; }
    public string GuiBloqueHomeNombreControl { get; set; } = null!;
    public string GuiBloqueHomeUrlBusqueda { get; set; } = null!;
    public string GuiBloqueHomeUrlNuevo { get; set; } = null!;
    public int GuiBloqueHomeOrden { get; set; }
    public string GuiBloqueHomeColorModulo { get; set; } = null!;
    public bool GuiBloqueHomeEsGenerico { get; set; }
    public string GuiBloqueHomeFiltro { get; set; } = null!;
    public string Multiempresa { get; set; } = null!;
}
