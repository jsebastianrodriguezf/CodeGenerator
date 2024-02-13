namespace SAMMAI.Transverse.Models.Objects;

public class DocPendienteDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PendienteDocumento { get; set; } = null!;
    public string? PendienteDocumentoCodigo { get; set; }
    public double? Cantidad { get; set; }
    public int IdDocumento { get; set; }
    public int IdCatalogo { get; set; }
    public int IdTipoDocumento { get; set; }
    public bool Olvidar { get; set; }
    public int IdReporteTecnico { get; set; }
    public int IdTipoPendiente { get; set; }
}
