namespace SAMMAI.Transverse.Models.Objects;

public class VDocumentosPadreAsociarObject
{
    public int Id { get; set; }
    public string Prefijo { get; set; } = null!;
    public int DocumentoNumero { get; set; }
    public int IdSubtipoDocumento { get; set; }
    public int IdEstadoTipoDocumento { get; set; }
    public int IdCliente { get; set; }
    public int? IdSucursal { get; set; }
    public int? IdEquipo { get; set; }
}
