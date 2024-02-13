namespace SAMMAI.Transverse.Models.Objects;

public class TerTerceroObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Tercero { get; set; } = null!;
    public string? TerceroCodigo { get; set; }
    public string TerceroNit { get; set; } = null!;
    public string? Direccion { get; set; }
    public string? Contacto { get; set; }
    public string Telefono { get; set; } = null!;
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? Representante { get; set; }
    public string? Notas { get; set; }
    public string TerceroNombreCorto { get; set; } = null!;
    public bool EsCliente { get; set; }
    public bool EsProveedor { get; set; }
    public bool EsTransportador { get; set; }
    public bool EsFabricante { get; set; }
    public bool EsEmpresaPropia { get; set; }
    public string? Clasificacion { get; set; }
    public int IdZona { get; set; }
    public int IdEstadoTercero { get; set; }
    public int IdNaturalezaTercero { get; set; }
    public bool EsProspecto { get; set; }
    public int? IdFormaPago { get; set; }
    public int? TiempoEntrega { get; set; }
}
