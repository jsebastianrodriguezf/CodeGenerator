namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenFirmaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Firma { get; set; } = null!;
    public string? FirmaCodigo { get; set; }
    public string Tabla { get; set; } = null!;
    public int Idobjeto { get; set; }
    public byte[]? Archivobinario { get; set; }
    public DateTime FechaFh { get; set; }
    public string Multiempresa { get; set; } = null!;
}
