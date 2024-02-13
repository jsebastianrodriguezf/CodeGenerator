namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenLocalizacionItemDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string LocalizacionItemDocumento { get; set; } = null!;
    public int IdLocalizacion { get; set; }
    public string GenLocalizacionLocalizacion { get; set; } = null!;
    public string? GenLocalizacionLocalizacionCodigo { get; set; }
    public int GenLocalizacionIdCatalogoBodega { get; set; }
    public int GenLocalizacionExistencia { get; set; }
    public int GenLocalizacionExistenciaMaxima { get; set; }
    public int IdItemDocumento { get; set; }
    public string DocItemDocumentoItemDocumento { get; set; } = null!;
    public string? DocItemDocumentoItemDocumentoCodigo { get; set; }
    public string DocItemDocumentoDetalle { get; set; } = null!;
    public double DocItemDocumentoHorasOrdinales { get; set; }
    public double DocItemDocumentoHorasFestivas { get; set; }
    public double DocItemDocumentoHorasNocturnas { get; set; }
    public double DocItemDocumentoCantidadPlaneado { get; set; }
    public double DocItemDocumentoCantidadEjecutado { get; set; }
    public decimal DocItemDocumentoValorUnitarioPlaneado { get; set; }
    public decimal DocItemDocumentoValorUnitarioEjecutado { get; set; }
    public decimal DocItemDocumentoSubtotalPlaneado { get; set; }
    public decimal DocItemDocumentoSubtotalEjecutado { get; set; }
    public decimal DocItemDocumentoTotalPlaneado { get; set; }
    public decimal DocItemDocumentoTotalEjecutado { get; set; }
    public double DocItemDocumentoPorciva { get; set; }
    public decimal DocItemDocumentoIvaPlaneado { get; set; }
    public decimal DocItemDocumentoIvaEjecutado { get; set; }
    public double DocItemDocumentoPorcdto { get; set; }
    public decimal DocItemDocumentoDtoPlaneado { get; set; }
    public decimal DocItemDocumentoDtoEjecutado { get; set; }
    public bool DocItemDocumentoCostear { get; set; }
    public bool DocItemDocumentoEsUrgente { get; set; }
    public DateTime? DocItemDocumentoVencimientoGarantiaFf { get; set; }
    public double? DocItemDocumentoHorasGarantia { get; set; }
    public double? DocItemDocumentoPorcentajeCliente { get; set; }
    public double? DocItemDocumentoPorcentajeDistribuidor { get; set; }
    public double? DocItemDocumentoPorcentajeFabricante { get; set; }
    public bool DocItemDocumentoAfectoInventario { get; set; }
    public int DocItemDocumentoIdDocumento { get; set; }
    public int DocItemDocumentoIdItemDocumento { get; set; }
    public int DocItemDocumentoIdCentroCosto { get; set; }
    public int DocItemDocumentoIdCatalogo { get; set; }
    public int DocItemDocumentoIdBodega { get; set; }
    public int DocItemDocumentoIdIncoterm { get; set; }
    public int DocItemDocumentoIdItemDocumentoSuperior { get; set; }
    public double DocItemDocumentoCostoPlaneado { get; set; }
    public double DocItemDocumentoCostoEjecutado { get; set; }
    public int DocItemDocumentoIdListaprecio { get; set; }
    public int Cantidad { get; set; }
    public string Multiempresa { get; set; } = null!;
}
