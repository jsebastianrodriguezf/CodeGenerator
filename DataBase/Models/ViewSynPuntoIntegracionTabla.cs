using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSynPuntoIntegracionTabla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PuntoIntegracionTabla { get; set; } = null!;

    public string? PuntoIntegracionTablaCodigo { get; set; }

    public int IdPuntoIntegracion { get; set; }

    public string SynPuntoIntegracionPuntoIntegracion { get; set; } = null!;

    public string? SynPuntoIntegracionPuntoIntegracionCodigo { get; set; }

    public string? SynPuntoIntegracionTablaLocal { get; set; }

    public string? SynPuntoIntegracionCondicion { get; set; }

    public string? SynPuntoIntegracionUrlConsumir { get; set; }

    public int? SynPuntoIntegracionIdPuntoIntegracion { get; set; }

    public int? SynPuntoIntegracionIdSistemaIntegrar { get; set; }

    public string? SynPuntoIntegracionMetodo { get; set; }

    public string Tabla { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
