namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoEstadoTipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoEstadoTipoDocumento { get; set; } = null!;
    public string? Notas { get; set; }
    public int IdDocumento { get; set; }
    public int IdEstadoTipoDocumento { get; set; }
    public int IdMotivoestado { get; set; }
}
