namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatAtributo : CatAtributoObject
{
    public virtual ICollection<CatAtributoOpcionAtributo> CatAtributoOpcionAtributos { get; set; } = new List<CatAtributoOpcionAtributo>();
    public virtual ICollection<CatPruebaCheckListAtributo> CatPruebaCheckListAtributos { get; set; } = new List<CatPruebaCheckListAtributo>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();
    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();
    public virtual ICollection<EquOpcionAtributo> EquOpcionAtributos { get; set; } = new List<EquOpcionAtributo>();
    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributos { get; set; } = new List<GenConfiguracionAtributo>();
    public virtual CatSeccionAtributo IdSeccionAtributoNavigation { get; set; } = null!;
    public virtual EquTipoAtributo IdTipoAtributoNavigation { get; set; } = null!;
    public virtual GenUnidad IdUnidadNavigation { get; set; } = null!;
}
