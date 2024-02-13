namespace SAMMAI.Transverse.Models.Objects;

public class DocSoporteItemDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SoporteItemDocumento { get; set; } = null!;
    public string? SoporteItemDocumentoCodigo { get; set; }
    public double DuracionPlaneada { get; set; }
    public decimal Valor { get; set; }
    public decimal Costo { get; set; }
    public int IdItemDocumento { get; set; }
    public int IdUsuario { get; set; }
    public double DuracionEjecutada { get; set; }
    public double HorasOrdinales { get; set; }
    public double HorasFestivas { get; set; }
    public double HorasNocturnas { get; set; }
    public string Periodo { get; set; } = null!;
}
