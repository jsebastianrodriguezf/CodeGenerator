using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquDetalleAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetalleAlquiler { get; set; } = null!;

    public string? DetalleAlquilerCodigo { get; set; }

    public DateTime FechaDevolucionFf { get; set; }

    public decimal ValorHora { get; set; }

    public decimal ValorHoraStandBy { get; set; }

    public decimal ValorPeriodo { get; set; }

    public decimal ValorMulta { get; set; }

    public DateTime FechaDespachoFf { get; set; }

    public int IdEquipo { get; set; }

    public string EquEquipoEquipo { get; set; } = null!;

    public string? EquEquipoEquipoCodigo { get; set; }

    public string EquEquipoEquipoSerial { get; set; } = null!;

    public string? EquEquipoNombreContacto { get; set; }

    public string? EquEquipoTelefonoContacto { get; set; }

    public string? EquEquipoUbicacion { get; set; }

    public string? EquEquipoObservaciones { get; set; }

    public DateTime? EquEquipoFechaPuestaMarchaFh { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaFabricaFf { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaDistribuidorFf { get; set; }

    public double? EquEquipoHorasGarantia { get; set; }

    public DateTime? EquEquipoUltimaLecturaFh { get; set; }

    public double EquEquipoHorometroActual { get; set; }

    public double EquEquipoPromedioHoras { get; set; }

    public decimal? EquEquipoCosto { get; set; }

    public DateTime? EquEquipoFechaImportacionFf { get; set; }

    public string? EquEquipoGarantiaCancelada { get; set; }

    public int EquEquipoIdCatalogoEquipo { get; set; }

    public int EquEquipoIdSistema { get; set; }

    public int EquEquipoIdSucursal { get; set; }

    public int EquEquipoIdZona { get; set; }

    public int EquEquipoIdVersionEquipo { get; set; }

    public int EquEquipoIdTerceroComprador { get; set; }

    public int EquEquipoIdTercero { get; set; }

    public int EquEquipoIdTerceroServicio { get; set; }

    public int EquEquipoIdEquipo { get; set; }

    public int EquEquipoIdEstadoEquipo { get; set; }

    public int IdDocumentoAlquiler { get; set; }

    public string DocDocumentoAlquilerDocumentoAlquiler { get; set; } = null!;

    public DateTime? DocDocumentoAlquilerFechaFinFf { get; set; }

    public bool DocDocumentoAlquilerMesVencido { get; set; }

    public string? DocDocumentoAlquilerObservaciones { get; set; }

    public string? DocDocumentoAlquilerDocumentoCodigo { get; set; }

    public int DocDocumentoAlquilerDocumentoNumero { get; set; }

    public string DocDocumentoAlquilerPrefijo { get; set; } = null!;

    public double DocDocumentoAlquilerSubtotal { get; set; }

    public double DocDocumentoAlquilerDescuento { get; set; }

    public double DocDocumentoAlquilerIva { get; set; }

    public double DocDocumentoAlquilerTotal { get; set; }

    public double DocDocumentoAlquilerCosto { get; set; }

    public double DocDocumentoAlquilerRentabilidad { get; set; }

    public double DocDocumentoAlquilerTrm { get; set; }

    public DateTime DocDocumentoAlquilerFechaFh { get; set; }

    public DateTime DocDocumentoAlquilerFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoAlquilerFechaCierreFf { get; set; }

    public DateTime DocDocumentoAlquilerFechaLimiteFh { get; set; }

    public int DocDocumentoAlquilerIdSubtipoDocumento { get; set; }

    public int DocDocumentoAlquilerIdTerceroCliente { get; set; }

    public int DocDocumentoAlquilerIdDocumento { get; set; }

    public int DocDocumentoAlquilerIdTerceroProveedor { get; set; }

    public int DocDocumentoAlquilerIdPrioridadDocumento { get; set; }

    public int DocDocumentoAlquilerIdMoneda { get; set; }

    public int DocDocumentoAlquilerIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoAlquilerIdMotivoestado { get; set; }

    public double DocDocumentoAlquilerSubtotalPlaneado { get; set; }

    public double DocDocumentoAlquilerDescuentoPlaneado { get; set; }

    public double DocDocumentoAlquilerIvaPlaneado { get; set; }

    public double DocDocumentoAlquilerTotalPlaneado { get; set; }

    public double DocDocumentoAlquilerCostoPlaneado { get; set; }

    public int IdSucursal { get; set; }

    public string TerSucursalSucursal { get; set; } = null!;

    public string? TerSucursalSucursalCodigo { get; set; }

    public string? TerSucursalContacto { get; set; }

    public string TerSucursalTelefono { get; set; } = null!;

    public string? TerSucursalFax { get; set; }

    public string? TerSucursalEmail { get; set; }

    public string? TerSucursalDireccion { get; set; }

    public bool TerSucursalParaVenta { get; set; }

    public bool TerSucursalParaSoporte { get; set; }

    public bool TerSucursalParaAlquiler { get; set; }

    public int TerSucursalIdTercero { get; set; }

    public int TerSucursalIdZona { get; set; }

    public int TerSucursalIdUsuarioAsesor { get; set; }

    public int TerSucursalIdUsuarioTecnico { get; set; }

    public int TerSucursalIdSucursal { get; set; }

    public int TerSucursalIdEstadoTercero { get; set; }

    public string? TerSucursalCodigorecursiva { get; set; }

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

    public DateTime? FechaUltimaFacturaFh { get; set; }

    public double? ValorMes { get; set; }

    public DateTime FechaInicioFacturaFh { get; set; }

    public int CantidadSolicitada { get; set; }

    public int CantidadAlquilada { get; set; }

    public int IdCatalogo { get; set; }

    public string CatCatalogoCatalogo { get; set; } = null!;

    public string? CatCatalogoCatalogoCodigo { get; set; }

    public string CatCatalogoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoPrecioVenta { get; set; }

    public int? CatCatalogoTiempoConsecucion { get; set; }

    public bool CatCatalogoEsNacional { get; set; }

    public int CatCatalogoIdFamilia { get; set; }

    public int CatCatalogoIdSubtipoCatalogo { get; set; }

    public int CatCatalogoIdUnidad { get; set; }

    public int CatCatalogoIdImpuesto { get; set; }

    public string CatCatalogoDescripcion { get; set; } = null!;

    public bool CatCatalogoBloquearCostear { get; set; }

    public int? Estadoalquiler { get; set; }

    public bool BloquearDespacho { get; set; }

    public bool EsSerializado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
