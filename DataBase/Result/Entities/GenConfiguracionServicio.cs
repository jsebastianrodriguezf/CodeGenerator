namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenConfiguracionServicio : GenConfiguracionServicioObject
{
    public virtual CatCatalogo? IdCatalogoNavigation { get; set; }
    public virtual TerTercero? IdTerceroNavigation { get; set; }
    public virtual GenTipoServicio? IdTipoServicioNavigation { get; set; }
}
