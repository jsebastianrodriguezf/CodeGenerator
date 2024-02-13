namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquOpcionAtributo : EquOpcionAtributoObject
{
    public virtual ICollection<CatAtributoOpcionAtributo> CatAtributoOpcionAtributos { get; set; } = new List<CatAtributoOpcionAtributo>();
    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();
    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();
    public virtual ICollection<EquOpcionAtributoDependiente> EquOpcionAtributoDependientes { get; set; } = new List<EquOpcionAtributoDependiente>();
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
}
