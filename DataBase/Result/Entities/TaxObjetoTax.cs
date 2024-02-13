namespace SAMMAI.DataBase.Repository.Entities;

public partial class TaxObjetoTax : TaxObjetoTaxObject
{
    public virtual TaxNivelTax IdNivelTaxNavigation { get; set; } = null!;
}
