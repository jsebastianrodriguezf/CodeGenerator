namespace SAMMAI.Transverse.Models.Objects;

public class ViewTaxNivelTaxObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string NivelTax { get; set; } = null!;
    public string? NivelTaxCodigo { get; set; }
    public int IdNivelTax { get; set; }
    public string TaxNivelTaxPadreNivelTax { get; set; } = null!;
    public string? TaxNivelTaxPadreNivelTaxCodigo { get; set; }
    public int TaxNivelTaxPadreIdNivelTax { get; set; }
    public string TaxNivelTaxPadreTabla { get; set; } = null!;
    public string TaxNivelTaxPadreFiltro { get; set; } = null!;
    public string TaxNivelTaxPadreColumnaPrincipal { get; set; } = null!;
    public bool TaxNivelTaxPadreEsEquipo { get; set; }
    public string Tabla { get; set; } = null!;
    public string Filtro { get; set; } = null!;
    public string ColumnaPrincipal { get; set; } = null!;
    public bool EsEquipo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
