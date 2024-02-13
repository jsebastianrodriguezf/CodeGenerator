using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatCatalogoTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoTempario { get; set; } = null!;

    public double? DuracionEstimada { get; set; }

    public bool EnTaller { get; set; }

    public bool EsCiclico { get; set; }

    public bool DetieneEquipos { get; set; }

    public double? HorasDetencion { get; set; }

    public int PeriodoHoras { get; set; }

    public bool FacturaTodo { get; set; }

    public int PeriodoDias { get; set; }

    public double PorcGarantia { get; set; }

    public double PorcTropicalizacion { get; set; }

    public int IdTipoServicio { get; set; }

    public string GenTipoServicioTipoServicio { get; set; } = null!;

    public string? GenTipoServicioTipoServicioCodigo { get; set; }

    public bool? GenTipoServicioTieneGarantia { get; set; }

    public int? GenTipoServicioDiasGarantia { get; set; }

    public bool Proyectar { get; set; }

    public bool IncluirMenores { get; set; }

    public int ModoAjuste { get; set; }

    public string? CatCatalogoTemparioCatalogoCodigo { get; set; }

    public string CatCatalogoTemparioCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoTemparioPrecioVenta { get; set; }

    public int? CatCatalogoTemparioTiempoConsecucion { get; set; }

    public bool CatCatalogoTemparioEsNacional { get; set; }

    public int CatCatalogoTemparioIdFamilia { get; set; }

    public string CatCatalogoTemparioGenFamiliaFamilia { get; set; } = null!;

    public string? CatCatalogoTemparioGenFamiliaFamiliaCodigo { get; set; }

    public int CatCatalogoTemparioGenFamiliaIdFamilia { get; set; }

    public int CatCatalogoTemparioIdSubtipoCatalogo { get; set; }

    public string CatCatalogoTemparioCatSubtipoCatalogoSubtipoCatalogo { get; set; } = null!;

    public string? CatCatalogoTemparioCatSubtipoCatalogoSubtipoCatalogoCodigo { get; set; }

    public int CatCatalogoTemparioCatSubtipoCatalogoIdTipoCatalogo { get; set; }

    public int CatCatalogoTemparioIdUnidad { get; set; }

    public string CatCatalogoTemparioGenUnidadUnidad { get; set; } = null!;

    public string? CatCatalogoTemparioGenUnidadUnidadCodigo { get; set; }

    public int CatCatalogoTemparioIdImpuesto { get; set; }

    public string CatCatalogoTemparioGenImpuestoImpuesto { get; set; } = null!;

    public string? CatCatalogoTemparioGenImpuestoImpuestoCodigo { get; set; }

    public double? CatCatalogoTemparioGenImpuestoValor { get; set; }

    public string CatCatalogoTemparioDescripcion { get; set; } = null!;

    public bool CatCatalogoTemparioBloquearCostear { get; set; }

    public string Multiempresa { get; set; } = null!;
}
