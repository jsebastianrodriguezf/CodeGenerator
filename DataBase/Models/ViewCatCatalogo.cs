using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Catalogo { get; set; } = null!;

    public string? CatalogoCodigo { get; set; }

    public string CodigoInventario { get; set; } = null!;

    public decimal? PrecioVenta { get; set; }

    public int? TiempoConsecucion { get; set; }

    public bool EsNacional { get; set; }

    public int IdFamilia { get; set; }

    public string GenFamiliaFamilia { get; set; } = null!;

    public string? GenFamiliaFamiliaCodigo { get; set; }

    public int GenFamiliaIdFamilia { get; set; }

    public int IdSubtipoCatalogo { get; set; }

    public string CatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;

    public string? CatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }

    public int CatSubtipoCatalogoIdTipoCatalogo { get; set; }

    public int IdUnidad { get; set; }

    public string GenUnidadUnidad { get; set; } = null!;

    public string? GenUnidadUnidadCodigo { get; set; }

    public int IdImpuesto { get; set; }

    public string GenImpuestoImpuesto { get; set; } = null!;

    public string? GenImpuestoImpuestoCodigo { get; set; }

    public double? GenImpuestoValor { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool BloquearCostear { get; set; }

    public string Multiempresa { get; set; } = null!;
}
