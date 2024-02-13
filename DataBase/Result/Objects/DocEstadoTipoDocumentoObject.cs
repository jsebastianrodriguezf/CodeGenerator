namespace SAMMAI.Transverse.Models.Objects;

public class DocEstadoTipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EstadoTipoDocumento { get; set; } = null!;
    public string? EstadoTipoDocumentoCodigo { get; set; }
    public bool AfectaIndicador { get; set; }
    public bool EditaDocumento { get; set; }
    public int Orden { get; set; }
    public bool PuedeRegresar { get; set; }
    public string Color { get; set; } = null!;
    public bool AfectaInventario { get; set; }
    public int IdTipoDocumento { get; set; }
    public string? Descripcion { get; set; }
    public bool ObservacionesObligatorio { get; set; }
    public bool MotivoObligatorio { get; set; }
}
