namespace SAMMAI.Transverse.Models.Objects;

public class TerContactoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Contacto { get; set; } = null!;
    public string? ContactoCodigo { get; set; }
    public string Telefono { get; set; } = null!;
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? Direccion { get; set; }
    public string? TelefonoMovil { get; set; }
    public int IdTercero { get; set; }
    public int IdUsuario { get; set; }
    public string? Cargo { get; set; }
    public string? CodigoAcceso { get; set; }
    public int? IdCargoContacto { get; set; }
    public bool AccesoActivo { get; set; }
    public int? TerCargoContactoIdUsuarioModifico { get; set; }
    public int? TerCargoContactoIdUsuarioCreo { get; set; }
}
