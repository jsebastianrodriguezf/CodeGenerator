namespace SAMMAI.Transverse.Models.Objects;

public class TerSucursalObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Sucursal { get; set; } = null!;
    public string? SucursalCodigo { get; set; }
    public string? Contacto { get; set; }
    public string Telefono { get; set; } = null!;
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? Direccion { get; set; }
    public bool ParaVenta { get; set; }
    public bool ParaSoporte { get; set; }
    public bool ParaAlquiler { get; set; }
    public int IdTercero { get; set; }
    public int IdZona { get; set; }
    public int IdUsuarioAsesor { get; set; }
    public int IdUsuarioTecnico { get; set; }
    public int IdSucursal { get; set; }
    public int IdEstadoTercero { get; set; }
    public string? Codigorecursiva { get; set; }
    public string Cargo { get; set; } = null!;
}
