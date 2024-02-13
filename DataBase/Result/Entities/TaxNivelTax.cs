namespace SAMMAI.DataBase.Repository.Entities;

public partial class TaxNivelTax : TaxNivelTaxObject
{
    public virtual TaxNivelTax IdNivelTaxNavigation { get; set; } = null!;
    public virtual ICollection<TaxNivelTax> InverseIdNivelTaxNavigation { get; set; } = new List<TaxNivelTax>();
    public virtual ICollection<TaxObjetoTax> TaxObjetoTaxes { get; set; } = new List<TaxObjetoTax>();
}
