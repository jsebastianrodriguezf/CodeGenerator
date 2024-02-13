using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatCatalogoEquipoCatalogoTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoEquipoCatalogoTempario { get; set; } = null!;

    public int IdCatalogoEquipo { get; set; }

    public string CatCatalogoEquipoCatalogoEquipo { get; set; } = null!;

    public int? CatCatalogoEquipoGarantiaMeses { get; set; }

    public int? CatCatalogoEquipoGarantiaHoras { get; set; }

    public bool CatCatalogoEquipoManejaHorometro { get; set; }

    public int CatCatalogoEquipoIdMarca { get; set; }

    public string? CatCatalogoEquipoCatalogoCodigo { get; set; }

    public string CatCatalogoEquipoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoEquipoPrecioVenta { get; set; }

    public int? CatCatalogoEquipoTiempoConsecucion { get; set; }

    public bool CatCatalogoEquipoEsNacional { get; set; }

    public int CatCatalogoEquipoIdFamilia { get; set; }

    public int CatCatalogoEquipoIdSubTipoCatalogo { get; set; }

    public int CatCatalogoEquipoIdUnidad { get; set; }

    public int CatCatalogoEquipoIdImpuesto { get; set; }

    public string CatCatalogoEquipoDescripcion { get; set; } = null!;

    public bool CatCatalogoEquipoBloquearCostear { get; set; }

    public int IdCatalogoTempario { get; set; }

    public string CatCatalogoTemparioCatalogoTempario { get; set; } = null!;

    public double? CatCatalogoTemparioDuracionEstimada { get; set; }

    public bool CatCatalogoTemparioEnTaller { get; set; }

    public bool CatCatalogoTemparioEsCiclico { get; set; }

    public bool CatCatalogoTemparioDetieneEquipos { get; set; }

    public double? CatCatalogoTemparioHorasDetencion { get; set; }

    public int CatCatalogoTemparioPeriodoHoras { get; set; }

    public bool CatCatalogoTemparioFacturaTodo { get; set; }

    public int CatCatalogoTemparioPeriodoDias { get; set; }

    public double CatCatalogoTemparioPorcGarantia { get; set; }

    public double CatCatalogoTemparioPorcTropicalizacion { get; set; }

    public int CatCatalogoTemparioIdTipoServicio { get; set; }

    public bool CatCatalogoTemparioProyectar { get; set; }

    public bool CatCatalogoTemparioIncluirMenores { get; set; }

    public int CatCatalogoTemparioModoAjuste { get; set; }

    public string? CatCatalogoTemparioCatalogoCodigo { get; set; }

    public string CatCatalogoTemparioCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoTemparioPrecioVenta { get; set; }

    public int? CatCatalogoTemparioTiempoConsecucion { get; set; }

    public bool CatCatalogoTemparioEsNacional { get; set; }

    public int CatCatalogoTemparioIdFamilia { get; set; }

    public int CatCatalogoTemparioIdSubTipoCatalogo { get; set; }

    public int CatCatalogoTemparioIdUnidad { get; set; }

    public int CatCatalogoTemparioIdImpuesto { get; set; }

    public string CatCatalogoTemparioDescripcion { get; set; } = null!;

    public bool CatCatalogoTemparioBloquearCostear { get; set; }

    public string CatSubtipocatalogoSubtipocatalogo { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
