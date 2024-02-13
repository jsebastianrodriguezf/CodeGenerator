namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquTipoAtributo : EquTipoAtributoObject
{
    public virtual ICollection<CatAtributo> CatAtributos { get; set; } = new List<CatAtributo>();
}
