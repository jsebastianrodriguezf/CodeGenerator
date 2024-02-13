using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSynCampoIntegracion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CampoIntegracion { get; set; } = null!;

    public string? CampoIntegracionCodigo { get; set; }

    public string? CampoLocal { get; set; }

    public string? TablaAuxiliar { get; set; }

    public string? CampoEnlace { get; set; }

    public string? ValorXdefecto { get; set; }

    public int? TipoDato { get; set; }

    public int? Longitud { get; set; }

    public int? Orden { get; set; }

    public int? IdPuntoIntegracion { get; set; }

    public string SynPuntoIntegracionPuntoIntegracion { get; set; } = null!;

    public string? SynPuntoIntegracionPuntoIntegracionCodigo { get; set; }

    public string? SynPuntoIntegracionTablaLocal { get; set; }

    public string? SynPuntoIntegracionCondicion { get; set; }

    public int? SynPuntoIntegracionIdPuntoIntegracion { get; set; }

    public int? SynPuntoIntegracionIdSistemaIntegrar { get; set; }

    public string? SynPuntoIntegracionUrlConsumir { get; set; }

    public bool? EsLlave { get; set; }

    public string Multiempresa { get; set; } = null!;
}
