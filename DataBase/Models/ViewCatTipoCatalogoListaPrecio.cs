using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatTipoCatalogoListaPrecio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoCatalogoListaPrecio { get; set; } = null!;

    public double Porcentaje { get; set; }

    public int IdTipoCatalogo { get; set; }

    public string CatTipoCatalogoTipoCatalogo { get; set; } = null!;

    public string? CatTipoCatalogoTipoCatalogoCodigo { get; set; }

    public bool CatTipoCatalogoAfectaInventario { get; set; }

    public bool CatTipoCatalogoAfectaProduccion { get; set; }

    public int IdListaPrecio { get; set; }

    public string CatListaPrecioListaPrecio { get; set; } = null!;

    public string? CatListaPrecioListaPrecioCodigo { get; set; }

    public double CatListaPrecioPorcentajeDescuento { get; set; }

    public bool CatListaPrecioEsPrivado { get; set; }

    public int CatListaPrecioIdMoneda { get; set; }

    public string Multiempresa { get; set; } = null!;
}
