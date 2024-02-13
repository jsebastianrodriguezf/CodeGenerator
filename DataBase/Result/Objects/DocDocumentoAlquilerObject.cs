namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoAlquilerObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoAlquiler { get; set; } = null!;
    public DateTime? FechaFinFf { get; set; }
    public bool MesVencido { get; set; }
    public string? Observaciones { get; set; }
    public bool EjecutaDevolucion { get; set; }
}
