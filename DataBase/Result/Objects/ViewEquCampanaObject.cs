namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquCampanaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Campana { get; set; } = null!;
    public string? CampanaCodigo { get; set; }
    public string DetalleCampana { get; set; } = null!;
    public DateTime FechaInicioFf { get; set; }
    public DateTime FechafinFf { get; set; }
    public bool Activo { get; set; }
    public int IdTercero { get; set; }
    public string TerTerceroTercero { get; set; } = null!;
    public string? TerTerceroTerceroCodigo { get; set; }
    public string TerTerceroTerceroNit { get; set; } = null!;
    public string? TerTerceroDireccion { get; set; }
    public string? TerTerceroContacto { get; set; }
    public string TerTerceroTelefono { get; set; } = null!;
    public string? TerTerceroFax { get; set; }
    public string? TerTerceroEmail { get; set; }
    public string? TerTerceroWebsite { get; set; }
    public string? TerTerceroRepresentante { get; set; }
    public string? TerTerceroNotas { get; set; }
    public string TerTerceroTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroEsCliente { get; set; }
    public bool TerTerceroEsProveedor { get; set; }
    public bool TerTerceroEsTransportador { get; set; }
    public bool TerTerceroEsFabricante { get; set; }
    public bool TerTerceroEsEmpresaPropia { get; set; }
    public string? TerTerceroClasificacion { get; set; }
    public int TerTerceroIdZona { get; set; }
    public int TerTerceroIdEstadoTercero { get; set; }
    public int TerTerceroIdNaturalezaTercero { get; set; }
    public bool TerTerceroEsProspecto { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
