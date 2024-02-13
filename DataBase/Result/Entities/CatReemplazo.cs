namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatReemplazo : CatReemplazoObject
{
    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();
    public virtual CatCatalogoRepuesto IdCatalogoRepuesto1Navigation { get; set; } = null!;
    public virtual CatCatalogoRepuesto IdCatalogoRepuestoNavigation { get; set; } = null!;
    public virtual CatTipoReemplazo IdTipoReemplazoNavigation { get; set; } = null!;
}
