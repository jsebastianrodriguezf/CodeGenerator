namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquAnalisisFallaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string AnalisisFalla { get; set; } = null!;
    public string? AnalisisFallaCodigo { get; set; }
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
    public int CatCatalogoEquipoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public bool CatCatalogoEquipoBloquearCostear { get; set; }
    public int IdFalla { get; set; }
    public string EquFallaFalla { get; set; } = null!;
    public string? EquFallaFallaCodigo { get; set; }
    public string EquFallaProcedimiento { get; set; } = null!;
    public int EquFallaIdTipoFalla { get; set; }
    public int EquFallaIdFalla { get; set; }
    public int IdFallaCausa { get; set; }
    public string EquFallaCausaFalla { get; set; } = null!;
    public string? EquFallaCausaFallaCodigo { get; set; }
    public string EquFallaCausaProcedimiento { get; set; } = null!;
    public int EquFallaCausaIdTipoFalla { get; set; }
    public int EquFallaCausaIdFalla { get; set; }
    public int IdFallaEfecto { get; set; }
    public string EquFallaEfectoFalla { get; set; } = null!;
    public string? EquFallaEfectoFallaCodigo { get; set; }
    public string EquFallaEfectoProcedimiento { get; set; } = null!;
    public int EquFallaEfectoIdTipoFalla { get; set; }
    public int EquFallaEfectoIdFalla { get; set; }
    public int IdFallaSolucion { get; set; }
    public string EquFallaSolucionFalla { get; set; } = null!;
    public string? EquFallaSolucionFallaCodigo { get; set; }
    public string EquFallaSolucionProcedimiento { get; set; } = null!;
    public int EquFallaSolucionIdTipoFalla { get; set; }
    public int EquFallaSolucionIdFalla { get; set; }
    public string Multiempresa { get; set; } = null!;
}
