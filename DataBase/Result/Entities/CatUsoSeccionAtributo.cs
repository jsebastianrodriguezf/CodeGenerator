namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatUsoSeccionAtributo : CatUsoSeccionAtributoObject
{
    public virtual ICollection<CatSeccionAtributo> CatSeccionAtributos { get; set; } = new List<CatSeccionAtributo>();
}
