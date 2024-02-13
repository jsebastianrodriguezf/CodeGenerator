namespace SAMMAI.Transverse.Models.Objects;

public class GenFirmaContactoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string FirmaContacto { get; set; } = null!;
    public string? FirmaContactoCodigo { get; set; }
    public int IdContacto { get; set; }
    public string Codigoacceso { get; set; } = null!;
    public byte[]? Archivobinario { get; set; }
    public DateTime FechaFh { get; set; }
}
