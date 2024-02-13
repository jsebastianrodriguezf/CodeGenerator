namespace SAMMAI.Transverse.Models.Objects;

public class TaxObjetoTaxObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ObjetoTax { get; set; } = null!;
    public string? ObjetoTaxCodigo { get; set; }
    public string Tabla { get; set; } = null!;
    public int IdTablaTax { get; set; }
    public int IdObjTax { get; set; }
    public int IdNivelTax { get; set; }
    public int Orden { get; set; }
}
