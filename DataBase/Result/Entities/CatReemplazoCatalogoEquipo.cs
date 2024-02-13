namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatReemplazoCatalogoEquipo : CatReemplazoCatalogoEquipoObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual CatReemplazo IdReemplazoNavigation { get; set; } = null!;
    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
}
