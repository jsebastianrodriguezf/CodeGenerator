namespace SAMMAI.Transverse.Models.Objects;

public class ViewLicLicenciumObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Licencia { get; set; } = null!;
    public string? LicenciaCodigo { get; set; }
    public string Serial { get; set; } = null!;
    public string Clave { get; set; } = null!;
    public DateTime FechaInicioFf { get; set; }
    public DateTime FechaFinFf { get; set; }
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
    public string Multiempresa { get; set; } = null!;
}
