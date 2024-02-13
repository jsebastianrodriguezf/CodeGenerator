namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatSeccionAtributo : CatSeccionAtributoObject
{
    public virtual ICollection<CatAtributo> CatAtributos { get; set; } = new List<CatAtributo>();
    public virtual CatUsoSeccionAtributo IdUsoSeccionAtributoNavigation { get; set; } = null!;
}
