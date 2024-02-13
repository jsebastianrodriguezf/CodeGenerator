using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquEquipoItemDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EquipoItemDocumento { get; set; } = null!;

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

    public int EquEquipoIdCentroCosto { get; set; }

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

    public int IdItemDocumento { get; set; }

    public int IdDocitemDocumento { get; set; }

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

    public double? DocItemDocumentoVrbase { get; set; }

    public double? DocItemDocumentoVrenlista { get; set; }

    public double? DocItemDocumentoPorcdescuento { get; set; }

    public double DocItemDocumentoCantAuxiliar { get; set; }

    public string Multiempresa { get; set; } = null!;
}
