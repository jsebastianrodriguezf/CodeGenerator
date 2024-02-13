namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerNaturalezaTercero : TerNaturalezaTerceroObject
{
    public virtual ICollection<TerTercero> TerTerceros { get; set; } = new List<TerTercero>();
}
