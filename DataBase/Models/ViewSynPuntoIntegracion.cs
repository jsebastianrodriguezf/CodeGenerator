using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSynPuntoIntegracion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PuntoIntegracion { get; set; } = null!;

    public string? PuntoIntegracionCodigo { get; set; }

    public string? TablaLocal { get; set; }

    public string? Condicion { get; set; }

    public string? UrlConsumir { get; set; }

    public int? IdPuntoIntegracion { get; set; }

    public string SynPuntoIntegracionPadrePuntoIntegracion { get; set; } = null!;

    public string? SynPuntoIntegracionPadrePuntoIntegracionCodigo { get; set; }

    public string? SynPuntoIntegracionPadreTablaLocal { get; set; }

    public string? SynPuntoIntegracionPadreCondicion { get; set; }

    public string? SynPuntoIntegracionPadreUrlConsumir { get; set; }

    public int? SynPuntoIntegracionPadreIdPuntoIntegracion { get; set; }

    public int? SynPuntoIntegracionPadreIdSistemaIntegrar { get; set; }

    public string? SynPuntoIntegracionPadreMetodo { get; set; }

    public int? SynPuntoIntegracionPadreCantidadReintentos { get; set; }

    public int? SynPuntoIntegracionPadreIntervaloReintentos { get; set; }

    public string? SynPuntoIntegracionPadreCodigosReintentos { get; set; }

    public int? IdSistemaIntegrar { get; set; }

    public string SynSistemaIntegrarSistemaIntegrar { get; set; } = null!;

    public string? SynSistemaIntegrarSistemaIntegrarCodigo { get; set; }

    public string? SynSistemaIntegrarUsuario { get; set; }

    public string? SynSistemaIntegrarClave { get; set; }

    public string? SynSistemaIntegrarUrlAutenticar { get; set; }

    public int SynSistemaIntegrarIdTipoAutenticacion { get; set; }

    public string? SynSistemaIntegrarToken { get; set; }

    public string? SynSistemaIntegrarMetodoAutenticar { get; set; }

    public string? SynSistemaIntegrarEstructuraResponseAutenticar { get; set; }

    public string? Metodo { get; set; }

    public int? CantidadReintentos { get; set; }

    public int? IntervaloReintentos { get; set; }

    public string? CodigosReintentos { get; set; }

    public string Multiempresa { get; set; } = null!;
}
