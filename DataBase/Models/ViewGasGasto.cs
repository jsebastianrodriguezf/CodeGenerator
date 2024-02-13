using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGasGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Gasto { get; set; } = null!;

    public string? GastoCodigo { get; set; }

    public int Numero { get; set; }

    public DateTime FechaFf { get; set; }

    public int Dias { get; set; }

    public double Valor { get; set; }

    public string Concepto { get; set; } = null!;

    public bool Consignado { get; set; }

    public int IdTipoGasto { get; set; }

    public string GasTipoGastoTipoGasto { get; set; } = null!;

    public string? GasTipoGastoTipoGastoCodigo { get; set; }

    public int IdUsuarioAprobo { get; set; }

    public string SegUsuarioAproboUsuario { get; set; } = null!;

    public string? SegUsuarioAproboUsuarioCodigo { get; set; }

    public int? SegUsuarioAproboIntentosFallidos { get; set; }

    public int? SegUsuarioAproboNumeroIngresos { get; set; }

    public DateTime? SegUsuarioAproboFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioAproboFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioAproboClave { get; set; }

    public string? SegUsuarioAproboNombre { get; set; }

    public string? SegUsuarioAproboProfesion { get; set; }

    public string SegUsuarioAproboEmail { get; set; } = null!;

    public string? SegUsuarioAproboDireccion { get; set; }

    public string? SegUsuarioAproboTelefono { get; set; }

    public decimal? SegUsuarioAproboCostoHora { get; set; }

    public double? SegUsuarioAproboPorcentajeComision { get; set; }

    public bool? SegUsuarioAproboAccesoActivo { get; set; }

    public bool? SegUsuarioAproboCambiarClave { get; set; }

    public DateTime? SegUsuarioAproboFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioAproboAplicaRecargo { get; set; }

    public bool SegUsuarioAproboSexo { get; set; }

    public int SegUsuarioAproboIdPerfil { get; set; }

    public int SegUsuarioAproboIdCargo { get; set; }

    public int SegUsuarioAproboIdGrupo { get; set; }

    public int SegUsuarioAproboIdZona { get; set; }

    public string? SegUsuarioAproboIdentificacion { get; set; }

    public int SegUsuarioAproboIdUsuario { get; set; }

    public byte[]? SegUsuarioAproboPreferencias { get; set; }

    public int IdUsuarioSolicitante { get; set; }

    public string SegUsuarioSolicitanteUsuario { get; set; } = null!;

    public string? SegUsuarioSolicitanteUsuarioCodigo { get; set; }

    public int? SegUsuarioSolicitanteIntentosFallidos { get; set; }

    public int? SegUsuarioSolicitanteNumeroIngresos { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioSolicitanteClave { get; set; }

    public string? SegUsuarioSolicitanteNombre { get; set; }

    public string? SegUsuarioSolicitanteProfesion { get; set; }

    public string SegUsuarioSolicitanteEmail { get; set; } = null!;

    public string? SegUsuarioSolicitanteDireccion { get; set; }

    public string? SegUsuarioSolicitanteTelefono { get; set; }

    public decimal? SegUsuarioSolicitanteCostoHora { get; set; }

    public double? SegUsuarioSolicitantePorcentajeComision { get; set; }

    public bool? SegUsuarioSolicitanteAccesoActivo { get; set; }

    public bool? SegUsuarioSolicitanteCambiarClave { get; set; }

    public DateTime? SegUsuarioSolicitanteFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioSolicitanteAplicaRecargo { get; set; }

    public bool SegUsuarioSolicitanteSexo { get; set; }

    public int SegUsuarioSolicitanteIdPerfil { get; set; }

    public int SegUsuarioSolicitanteIdCargo { get; set; }

    public int SegUsuarioSolicitanteIdGrupo { get; set; }

    public int SegUsuarioSolicitanteIdZona { get; set; }

    public string? SegUsuarioSolicitanteIdentificacion { get; set; }

    public int SegUsuarioSolicitanteIdUsuario { get; set; }

    public byte[]? SegUsuarioSolicitantePreferencias { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public string DocEstadoTipoDocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? DocEstadoTipoDocumentoEstadoTipoDocumentoCodigo { get; set; }

    public bool DocEstadoTipoDocumentoAfectaIndicador { get; set; }

    public bool DocEstadoTipoDocumentoEditaDocumento { get; set; }

    public int DocEstadoTipoDocumentoOrden { get; set; }

    public bool DocEstadoTipoDocumentoPuedeRegresar { get; set; }

    public string DocEstadoTipoDocumentoColor { get; set; } = null!;

    public bool DocEstadoTipoDocumentoAfectaInventario { get; set; }

    public int DocEstadoTipoDocumentoIdTipoDocumento { get; set; }

    public string? DocEstadoTipoDocumentoDescripcion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
