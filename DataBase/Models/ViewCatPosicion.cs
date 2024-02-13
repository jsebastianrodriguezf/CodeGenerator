using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatPosicion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Posicion { get; set; } = null!;

    public string? PosicionCodigo { get; set; }

    public int IdCatalogoEquipoEquipo { get; set; }

    public string CatCatalogoEquipoEquipoCatalogoEquipo { get; set; } = null!;

    public int? CatCatalogoEquipoEquipoGarantiaMeses { get; set; }

    public int? CatCatalogoEquipoEquipoGarantiaHoras { get; set; }

    public bool CatCatalogoEquipoEquipoManejaHorometro { get; set; }

    public int CatCatalogoEquipoEquipoIdMarca { get; set; }

    public string? CatCatalogoEquipoEquipoCatalogoCodigo { get; set; }

    public string CatCatalogoEquipoEquipoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoEquipoEquipoPrecioVenta { get; set; }

    public int? CatCatalogoEquipoEquipoTiempoConsecucion { get; set; }

    public bool CatCatalogoEquipoEquipoEsNacional { get; set; }

    public int CatCatalogoEquipoEquipoIdFamilia { get; set; }

    public int CatCatalogoEquipoEquipoIdSubtipoCatalogo { get; set; }

    public int CatCatalogoEquipoEquipoIdUnidad { get; set; }

    public int CatCatalogoEquipoEquipoIdImpuesto { get; set; }

    public string CatCatalogoEquipoEquipoDescripcion { get; set; } = null!;

    public bool CatCatalogoEquipoEquipoBloquearCostear { get; set; }

    public int IdCatalogoEquipoComponente { get; set; }

    public string CatCatalogoEquipoComponenteCatalogoEquipo { get; set; } = null!;

    public int? CatCatalogoEquipoComponenteGarantiaMeses { get; set; }

    public int? CatCatalogoEquipoComponenteGarantiaHoras { get; set; }

    public bool CatCatalogoEquipoComponenteManejaHorometro { get; set; }

    public int CatCatalogoEquipoComponenteIdMarca { get; set; }

    public string? CatCatalogoEquipoComponenteCatalogoCodigo { get; set; }

    public string CatCatalogoEquipoComponenteCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoEquipoComponentePrecioVenta { get; set; }

    public int? CatCatalogoEquipoComponenteTiempoConsecucion { get; set; }

    public bool CatCatalogoEquipoComponenteEsNacional { get; set; }

    public int CatCatalogoEquipoComponenteIdFamilia { get; set; }

    public int CatCatalogoEquipoComponenteIdSubtipoCatalogo { get; set; }

    public int CatCatalogoEquipoComponenteIdUnidad { get; set; }

    public int CatCatalogoEquipoComponenteIdImpuesto { get; set; }

    public string CatCatalogoEquipoComponenteDescripcion { get; set; } = null!;

    public bool CatCatalogoEquipoComponenteBloquearCostear { get; set; }

    public int IdDimensionX { get; set; }

    public string CatDimensionXDimension { get; set; } = null!;

    public string? CatDimensionXDimensionCodigo { get; set; }

    public bool CatDimensionXAplicaEnX { get; set; }

    public bool CatDimensionXAplicaEnY { get; set; }

    public bool CatDimensionXAplicaEnZ { get; set; }

    public int IdDimensionY { get; set; }

    public string CatDimensionYDimension { get; set; } = null!;

    public string? CatDimensionYDimensionCodigo { get; set; }

    public bool CatDimensionYAplicaEnX { get; set; }

    public bool CatDimensionYAplicaEnY { get; set; }

    public bool CatDimensionYAplicaEnZ { get; set; }

    public int IdDimensionZ { get; set; }

    public string CatDimensionZDimension { get; set; } = null!;

    public string? CatDimensionZDimensionCodigo { get; set; }

    public bool CatDimensionZAplicaEnX { get; set; }

    public bool CatDimensionZAplicaEnY { get; set; }

    public bool CatDimensionZAplicaEnZ { get; set; }

    public string Multiempresa { get; set; } = null!;
}
