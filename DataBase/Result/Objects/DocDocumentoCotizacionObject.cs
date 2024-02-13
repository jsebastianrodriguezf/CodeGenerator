namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoCotizacionObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoCotizacion { get; set; } = null!;
    public int Version { get; set; }
    public int Validez { get; set; }
    public string Contacto { get; set; } = null!;
    public string Cargo { get; set; } = null!;
    public string Encabezado { get; set; } = null!;
    public string Condiciones { get; set; } = null!;
    public string Notas { get; set; } = null!;
    public bool EsAiu { get; set; }
    public double? ProcentajeA { get; set; }
    public double? ProcentajeI { get; set; }
    public double? ProcentajeU { get; set; }
    public double? ValorA { get; set; }
    public double? ValorI { get; set; }
    public double? ValorU { get; set; }
    public int IdSucursal { get; set; }
    public int IdEquipo { get; set; }
    public int IdUsuarioAsesor { get; set; }
    public string? Email { get; set; }
    public string? Telefono { get; set; }
}
