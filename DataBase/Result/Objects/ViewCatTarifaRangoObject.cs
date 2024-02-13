namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatTarifaRangoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TarifaRango { get; set; } = null!;
    public string? TarifaRangoCodigo { get; set; }
    public double? RangoInicio { get; set; }
    public double? RangoFin { get; set; }
    public double? Precio { get; set; }
    public int IdTarifa { get; set; }
    public string CatTarifaTarifa { get; set; } = null!;
    public string? CatTarifaTarifaCodigo { get; set; }
    public bool? CatTarifaIncluyeRepuestos { get; set; }
    public bool? CatTarifaExterno { get; set; }
    public bool? CatTarifaTaller { get; set; }
    public decimal CatTarifaPrecio { get; set; }
    public bool CatTarifaValorPorUnidad { get; set; }
    public double? CatTarifaMinimo { get; set; }
    public int? CatTarifaEstrategia { get; set; }
    public int CatTarifaPrioridad { get; set; }
    public int CatTarifaIdMarca { get; set; }
    public int CatTarifaIdCargo { get; set; }
    public int CatTarifaIdTipoServicio { get; set; }
    public int CatTarifaIdFamilia { get; set; }
    public int CatTarifaIdAtributo { get; set; }
    public int CatTarifaIdZona { get; set; }
    public int CatTarifaIdCatalogoEquipo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
