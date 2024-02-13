namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenConfiguracionAtributo : GenConfiguracionAtributoObject
{
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
    public virtual GenFormulario IdFormularioNavigation { get; set; } = null!;
    public virtual Tabla? IdTablaRelacionNavigation { get; set; }
    public virtual Tabla? IdTablaResultadoNavigation { get; set; }
}
