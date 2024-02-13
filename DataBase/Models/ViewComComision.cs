using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewComComision
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Comision { get; set; } = null!;

    public string? ComisionCodigo { get; set; }

    public double? DescuentoMaximo { get; set; }

    public double? DescuentoMinimo { get; set; }

    public int IdCargo { get; set; }

    public string SegCargoCargo { get; set; } = null!;

    public string? SegCargoCargoCodigo { get; set; }

    public bool? SegCargoEsTecnico { get; set; }

    public bool? SegCargoEsComercial { get; set; }

    public bool? SegCargoEsCoordinador { get; set; }

    public decimal? SegCargoValorHora { get; set; }

    public bool SegCargoEsAdministrativo { get; set; }

    public int IdSubTipoCatalogo { get; set; }

    public string CatSubTipoCatalogoSubTipoCatalogo { get; set; } = null!;

    public string? CatSubTipoCatalogoSubTipoCatalogoCodigo { get; set; }

    public int CatSubTipoCatalogoIdTipoCatalogo { get; set; }

    public bool? Costear { get; set; }

    public int? Nivelnegocio { get; set; }

    public double? PorcComision { get; set; }

    public int IdCondicion { get; set; }

    public string DocCondicionCondicion { get; set; } = null!;

    public string? DocCondicionCondicionCodigo { get; set; }

    public bool DocCondicionTextoLibre { get; set; }

    public int IdOpcionCondicion { get; set; }

    public string DocOpcionCondicionOpcionCondicion { get; set; } = null!;

    public string? DocOpcionCondicionOpcionCondicionCodigo { get; set; }

    public int DocOpcionCondicionIdCondicion { get; set; }

    public int IdZona { get; set; }

    public string GenZonaZona { get; set; } = null!;

    public string? GenZonaZonaCodigo { get; set; }

    public double? GenZonaTiempoDesplazamiento { get; set; }

    public int GenZonaNivel { get; set; }

    public int GenZonaIdZona { get; set; }

    public string? GenZonaCodigoExterno { get; set; }

    public string Multiempresa { get; set; } = null!;
}
