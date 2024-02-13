namespace SAMMAI.Transverse.Models.Objects;

public class ViewCntConfigContratoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ConfigContrato { get; set; } = null!;
    public int? IdContratoEquipo { get; set; }
    public string CntContratoEquipoContratoEquipo { get; set; } = null!;
    public string? CntContratoEquipoContratoEquipoCodigo { get; set; }
    public decimal? CntContratoEquipoPrecioVisita { get; set; }
    public decimal? CntContratoEquipoPrecioServicio { get; set; }
    public DateTime? CntContratoEquipoFechaFf { get; set; }
    public double? CntContratoEquipoPromedio { get; set; }
    public int CntContratoEquipoIdEquipo { get; set; }
    public int CntContratoEquipoIdContrato { get; set; }
    public int CntContratoEquipoIdContratoDetalleVisita { get; set; }
    public int? IdCatalogoTempario { get; set; }
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
    public int CatCatalogoTemparioIdSubtipoCatalogo { get; set; }
    public int CatCatalogoTemparioIdUnidad { get; set; }
    public int CatCatalogoTemparioIdImpuesto { get; set; }
    public string CatCatalogoTemparioDescripcion { get; set; } = null!;
    public bool CatCatalogoTemparioBloquearCostear { get; set; }
    public int? IdTerceroProveedor { get; set; }
    public string TerTerceroProveedorTercero { get; set; } = null!;
    public string? TerTerceroProveedorTerceroCodigo { get; set; }
    public string TerTerceroProveedorTerceroNit { get; set; } = null!;
    public string? TerTerceroProveedorDireccion { get; set; }
    public string? TerTerceroProveedorContacto { get; set; }
    public string TerTerceroProveedorTelefono { get; set; } = null!;
    public string? TerTerceroProveedorFax { get; set; }
    public string? TerTerceroProveedorEmail { get; set; }
    public string? TerTerceroProveedorWebsite { get; set; }
    public string? TerTerceroProveedorRepresentante { get; set; }
    public string? TerTerceroProveedorNotas { get; set; }
    public string TerTerceroProveedorTerceroNombreCorto { get; set; } = null!;
    public bool TerTerceroProveedorEsCliente { get; set; }
    public bool TerTerceroProveedorEsProveedor { get; set; }
    public bool TerTerceroProveedorEsTransportador { get; set; }
    public bool TerTerceroProveedorEsFabricante { get; set; }
    public bool TerTerceroProveedorEsEmpresaPropia { get; set; }
    public string? TerTerceroProveedorClasificacion { get; set; }
    public int TerTerceroProveedorIdZona { get; set; }
    public int TerTerceroProveedorIdEstadoTercero { get; set; }
    public int TerTerceroProveedorIdNaturalezaTercero { get; set; }
    public bool TerTerceroProveedorEsProspecto { get; set; }
    public int? Frecuencia { get; set; }
    public double? CadaN { get; set; }
    public int? Dia { get; set; }
    public int? Estrategia { get; set; }
    public bool? PorTrabajo { get; set; }
    public bool? IncluirMenores { get; set; }
    public int? AproximarA { get; set; }
    public DateTime? FechaFf { get; set; }
    public int? DiaHabil { get; set; }
    public string Multiempresa { get; set; } = null!;
}
