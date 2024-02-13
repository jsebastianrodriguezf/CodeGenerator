namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatAtributoOpcionAtributo : CatAtributoOpcionAtributoObject
{
    public virtual CatAtributo? IdAtributoNavigation { get; set; }
    public virtual EquOpcionAtributo? IdOpcionAtributoNavigation { get; set; }
}
