using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDisEventoCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EventoCatalogo { get; set; } = null!;

    public bool EquipoAuxiliar { get; set; }

    public double? Cantidad { get; set; }

    public double? ValorUnitario { get; set; }

    public double? Total { get; set; }

    public int IdEvento { get; set; }

    public string DisEventoEvento { get; set; } = null!;

    public string? DisEventoEventoCodigo { get; set; }

    public DateTime DisEventoFechaHoraInicioFf { get; set; }

    public DateTime DisEventoDuracionHh { get; set; }

    public bool DisEventoAfectaProduccion { get; set; }

    public string? DisEventoNotas { get; set; }

    public int DisEventoIdEquipo { get; set; }

    public int DisEventoIdMotivoEvento { get; set; }

    public int DisEventoIdUsuario { get; set; }

    public int DisEventoIdEstadoEquipo { get; set; }

    public int DisEventoIdFalla { get; set; }

    public int DisEventoIdFallaCausa { get; set; }

    public int DisEventoIdMetodoDeteccion { get; set; }

    public DateTime DisEventoFechaHoraEstimadaFh { get; set; }

    public int DisEventoEventoTipo { get; set; }

    public bool DisEventoAfectaCliente { get; set; }

    public int DisEventoIdEstadoEvento { get; set; }

    public string? DisEventoCodigo { get; set; }

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

    public string Observaciones { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
