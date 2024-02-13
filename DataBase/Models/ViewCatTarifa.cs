using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatTarifa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Tarifa { get; set; } = null!;

    public string? TarifaCodigo { get; set; }

    public bool? IncluyeRepuestos { get; set; }

    public bool? Externo { get; set; }

    public bool? Taller { get; set; }

    public decimal Precio { get; set; }

    public bool ValorPorUnidad { get; set; }

    public double? Minimo { get; set; }

    public int? Estrategia { get; set; }

    public int Prioridad { get; set; }

    public int IdMarca { get; set; }

    public string CatMarcaMarca { get; set; } = null!;

    public string? CatMarcaMarcaCodigo { get; set; }

    public int CatMarcaIdTerceroFabricante { get; set; }

    public int IdCargo { get; set; }

    public string SegCargoCargo { get; set; } = null!;

    public string? SegCargoCargoCodigo { get; set; }

    public bool? SegCargoEsTecnico { get; set; }

    public bool? SegCargoEsComercial { get; set; }

    public bool? SegCargoEsCoordinador { get; set; }

    public decimal? SegCargoValorHora { get; set; }

    public bool SegCargoEsAdministrativo { get; set; }

    public int IdTipoServicio { get; set; }

    public string GenTipoServicioTipoServicio { get; set; } = null!;

    public string? GenTipoServicioTipoServicioCodigo { get; set; }

    public bool? GenTipoServicioTieneGarantia { get; set; }

    public int? GenTipoServicioDiasGarantia { get; set; }

    public int IdFamilia { get; set; }

    public string GenFamiliaFamilia { get; set; } = null!;

    public string? GenFamiliaFamiliaCodigo { get; set; }

    public int GenFamiliaIdFamilia { get; set; }

    public int IdAtributo { get; set; }

    public string CatAtributoAtributo { get; set; } = null!;

    public string? CatAtributoAtributoCodigo { get; set; }

    public string CatAtributoNombreControl { get; set; } = null!;

    public bool CatAtributoEsVariable { get; set; }

    public bool CatAtributoResaltado { get; set; }

    public double? CatAtributoValorMinimo { get; set; }

    public double? CatAtributoValorMaximo { get; set; }

    public int CatAtributoIdSeccionAtributo { get; set; }

    public int CatAtributoIdTipoAtributo { get; set; }

    public int CatAtributoIdUnidad { get; set; }

    public bool CatAtributoEsObligatorio { get; set; }

    public int IdZona { get; set; }

    public string GenZonaZona { get; set; } = null!;

    public string? GenZonaZonaCodigo { get; set; }

    public double? GenZonaTiempoDesplazamiento { get; set; }

    public int GenZonaNivel { get; set; }

    public int GenZonaIdZona { get; set; }

    public string? GenZonaCodigoExterno { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
