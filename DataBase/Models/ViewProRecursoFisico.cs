using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProRecursoFisico
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RecursoFisico { get; set; } = null!;

    public string? RecursoFisicoCodigo { get; set; }

    public double Costo { get; set; }

    public string UnidadTiempo { get; set; } = null!;

    public bool EsPropio { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
