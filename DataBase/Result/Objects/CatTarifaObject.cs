namespace SAMMAI.Transverse.Models.Objects;

public class CatTarifaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Tarifa { get; set; } = null!;
    public string? TarifaCodigo { get; set; }
    public bool? IncluyeRepuestos { get; set; }
    public bool? Externo { get; set; }
    public bool? Taller { get; set; }
    public decimal Precio { get; set; }
    public bool ValorPorUnidad { get; set; }
    public double? Minimo { get; set; }
    public int? Estrategia { get; set; }
    public int Prioridad { get; set; }
    public int IdMarca { get; set; }
    public int IdCargo { get; set; }
    public int IdTipoServicio { get; set; }
    public int IdFamilia { get; set; }
    public int IdAtributo { get; set; }
    public int IdZona { get; set; }
    public int IdCatalogoEquipo { get; set; }
}
