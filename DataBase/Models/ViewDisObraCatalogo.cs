using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDisObraCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ObraCatalogo { get; set; } = null!;

    public double Cantidad { get; set; }

    public double ValorUnitario { get; set; }

    public double Total { get; set; }

    public double PromedioDia { get; set; }

    public int IdObra { get; set; }

    public string DisObraObra { get; set; } = null!;

    public string? DisObraObraCodigo { get; set; }

    public DateTime DisObraFechaInicialFf { get; set; }

    public DateTime? DisObraFechaFinalFf { get; set; }

    public int DisObraIdSucursal { get; set; }

    public int IdCatalogo { get; set; }

    public string CatCatalogoCatalogo { get; set; } = null!;

    public string? CatCatalogoCatalogoCodigo { get; set; }

    public string CatCatalogoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoPrecioVenta { get; set; }

    public int? CatCatalogoTiempoConsecucion { get; set; }

    public bool CatCatalogoEsNacional { get; set; }

    public int CatCatalogoIdFamilia { get; set; }

    public int CatCatalogoIdSubtipoCatalogo { get; set; }

    public int CatCatalogoIdUnidad { get; set; }

    public int CatCatalogoIdImpuesto { get; set; }

    public string CatCatalogoDescripcion { get; set; } = null!;

    public bool CatCatalogoBloquearCostear { get; set; }

    public double? ValorMaximo { get; set; }

    public double? ValorMinimo { get; set; }

    public string Multiempresa { get; set; } = null!;
}
