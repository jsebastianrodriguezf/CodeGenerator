using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatCatalogoBodega
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoBodega { get; set; } = null!;

    public double Disponible { get; set; }

    public double Existencia { get; set; }

    public double Reservado { get; set; }

    public double ExistenciaMinima { get; set; }

    public double? EnOrdenes { get; set; }

    public string? Localizacion { get; set; }

    public decimal Costo { get; set; }

    public double? ExistenciaMaxima { get; set; }

    public int IdCatalogo { get; set; }

    public string CatCatalogoCatalogo { get; set; } = null!;

    public string? CatCatalogoCatalogoCodigo { get; set; }

    public string CatCatalogoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoPrecioVenta { get; set; }

    public int? CatCatalogoTiempoConsecucion { get; set; }

    public bool CatCatalogoEsNacional { get; set; }

    public int CatCatalogoIdFamilia { get; set; }

    public int CatCatalogoIdSubTipoCatalogo { get; set; }

    public int CatCatalogoIdUnidad { get; set; }

    public int CatCatalogoIdImpuesto { get; set; }

    public string CatCatalogoDescripcion { get; set; } = null!;

    public bool CatCatalogoBloquearCostear { get; set; }

    public int IdBodega { get; set; }

    public string GenBodegaBodega { get; set; } = null!;

    public string? GenBodegaBodegaCodigo { get; set; }

    public bool GenBodegaSalidasEnRojo { get; set; }

    public bool GenBodegaUsaLocalizacion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
