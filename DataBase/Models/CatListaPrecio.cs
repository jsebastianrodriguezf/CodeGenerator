using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatListaPrecio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ListaPrecio { get; set; } = null!;

    public string? ListaPrecioCodigo { get; set; }

    public double PorcentajeDescuento { get; set; }

    public bool EsPrivado { get; set; }

    public int IdMoneda { get; set; }

    public bool? ParaCompra { get; set; }

    public virtual ICollection<CatCatalogoListaPrecio> CatCatalogoListaPrecios { get; set; } = new List<CatCatalogoListaPrecio>();

    public virtual ICollection<CatTipoCatalogoListaPrecio> CatTipoCatalogoListaPrecios { get; set; } = new List<CatTipoCatalogoListaPrecio>();

    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();

    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();

    public virtual GenMonedum IdMonedaNavigation { get; set; } = null!;

    public virtual ICollection<TerSucursalListaprecio> TerSucursalListaprecios { get; set; } = new List<TerSucursalListaprecio>();

    public virtual ICollection<TerTerceroListaprecio> TerTerceroListaprecios { get; set; } = new List<TerTerceroListaprecio>();
}
