using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatCatalogoProducto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoProducto { get; set; } = null!;

    public string? CatCatalogoProductoCatalogoCodigo { get; set; }

    public string CatCatalogoProductoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoProductoPrecioVenta { get; set; }

    public int? CatCatalogoProductoTiempoConsecucion { get; set; }

    public bool CatCatalogoProductoEsNacional { get; set; }

    public int CatCatalogoProductoIdFamilia { get; set; }

    public string CatCatalogoProductoGenFamiliaFamilia { get; set; } = null!;

    public string? CatCatalogoProductoGenFamiliaFamiliaCodigo { get; set; }

    public int CatCatalogoProductoGenFamiliaIdFamilia { get; set; }

    public int CatCatalogoProductoIdSubtipoCatalogo { get; set; }

    public string CatCatalogoProductoCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;

    public string? CatCatalogoProductoCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }

    public int CatCatalogoProductoCatSubtipoCatalogoIdTipoCatalogo { get; set; }

    public int CatCatalogoProductoIdUnidad { get; set; }

    public string CatCatalogoProductoGenUnidadUnidad { get; set; } = null!;

    public string? CatCatalogoProductoGenUnidadUnidadCodigo { get; set; }

    public int CatCatalogoProductoIdImpuesto { get; set; }

    public string CatCatalogoProductoGenImpuestoImpuesto { get; set; } = null!;

    public string? CatCatalogoProductoGenImpuestoImpuestoCodigo { get; set; }

    public double? CatCatalogoProductoGenImpuestoValor { get; set; }

    public string CatCatalogoProductoDescripcion { get; set; } = null!;

    public bool CatCatalogoProductoBloquearCostear { get; set; }

    public string Multiempresa { get; set; } = null!;
}
