namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatListaPrecio : CatListaPrecioObject
{
    public virtual ICollection<CatCatalogoListaPrecio> CatCatalogoListaPrecios { get; set; } = new List<CatCatalogoListaPrecio>();
    public virtual ICollection<CatTipoCatalogoListaPrecio> CatTipoCatalogoListaPrecios { get; set; } = new List<CatTipoCatalogoListaPrecio>();
    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
    public virtual GenMonedum IdMonedaNavigation { get; set; } = null!;
    public virtual ICollection<TerSucursalListaprecio> TerSucursalListaprecios { get; set; } = new List<TerSucursalListaprecio>();
    public virtual ICollection<TerTerceroListaprecio> TerTerceroListaprecios { get; set; } = new List<TerTerceroListaprecio>();
}
