namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocOpcionCondicionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string OpcionCondicion { get; set; } = null!;
    public string? OpcionCondicionCodigo { get; set; }
    public int IdCondicion { get; set; }
    public string DocCondicionCondicion { get; set; } = null!;
    public string? DocCondicionCondicionCodigo { get; set; }
    public bool DocCondicionTextoLibre { get; set; }
    public string Multiempresa { get; set; } = null!;
}
