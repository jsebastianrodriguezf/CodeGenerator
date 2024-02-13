using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSegCargoActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CargoActividad { get; set; } = null!;

    public int IdCargo { get; set; }

    public string SegCargoCargo { get; set; } = null!;

    public string? SegCargoCargoCodigo { get; set; }

    public bool? SegCargoEsTecnico { get; set; }

    public bool? SegCargoEsComercial { get; set; }

    public bool? SegCargoEsCoordinador { get; set; }

    public decimal? SegCargoValorHora { get; set; }

    public bool SegCargoEsAdministrativo { get; set; }

    public int IdCatalogoActividad { get; set; }

    public string CatCatalogoActividadCatalogoActividad { get; set; } = null!;

    public bool? CatCatalogoActividadEsProductiva { get; set; }

    public double? CatCatalogoActividadDuracionEstimada { get; set; }

    public string? CatCatalogoActividadProcedimiento { get; set; }

    public string? CatCatalogoActividadCatalogoCodigo { get; set; }

    public string CatCatalogoActividadCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoActividadPrecioVenta { get; set; }

    public int? CatCatalogoActividadTiempoConsecucion { get; set; }

    public bool CatCatalogoActividadEsNacional { get; set; }

    public int CatCatalogoActividadIdFamilia { get; set; }

    public int CatCatalogoActividadIdSubTipoCatalogo { get; set; }

    public int CatCatalogoActividadIdUnidad { get; set; }

    public int CatCatalogoActividadIdImpuesto { get; set; }

    public string CatCatalogoActividadDescripcion { get; set; } = null!;

    public bool CatCatalogoActividadBloquearCostear { get; set; }

    public string Multiempresa { get; set; } = null!;
}
