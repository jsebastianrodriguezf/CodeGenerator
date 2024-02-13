namespace SAMMAI.Transverse.Models.Objects;

public class DocTipoDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TipoDocumento { get; set; } = null!;
    public string? TipoDocumentoCodigo { get; set; }
    public bool EsSalida { get; set; }
    public bool MostrarBodega { get; set; }
    public bool MostrarCentroCosto { get; set; }
    public bool MostrarIncoterm { get; set; }
    public bool PuedeSerMayor { get; set; }
    public bool PuedeSerMenor { get; set; }
    public bool EsUrgente { get; set; }
}
