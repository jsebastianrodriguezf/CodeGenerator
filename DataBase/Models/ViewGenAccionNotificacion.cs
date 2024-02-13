using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenAccionNotificacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string AccionNotificacion { get; set; } = null!;

    public string? AccionNotificacionCodigo { get; set; }

    public int? IdTipoNotificacion { get; set; }

    public string GenTipoNotificacionTipoNotificacion { get; set; } = null!;

    public string? GenTipoNotificacionTipoNotificacionCodigo { get; set; }

    public int? IdPuntoIntegracion { get; set; }

    public string SynPuntoIntegracionPuntoIntegracion { get; set; } = null!;

    public string? SynPuntoIntegracionPuntoIntegracionCodigo { get; set; }

    public string? SynPuntoIntegracionTablaLocal { get; set; }

    public string? SynPuntoIntegracionCondicion { get; set; }

    public string? SynPuntoIntegracionUrlConsumir { get; set; }

    public int? SynPuntoIntegracionIdPuntoIntegracion { get; set; }

    public int? SynPuntoIntegracionIdSistemaIntegrar { get; set; }

    public string? SynPuntoIntegracionMetodo { get; set; }

    public int? SynPuntoIntegracionCantidadReintentos { get; set; }

    public int? SynPuntoIntegracionIntervaloReintentos { get; set; }

    public string? SynPuntoIntegracionCodigosReintentos { get; set; }

    public string Multiempresa { get; set; } = null!;
}
