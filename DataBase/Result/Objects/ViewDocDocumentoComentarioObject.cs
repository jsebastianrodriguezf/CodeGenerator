namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoComentarioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoComentario { get; set; } = null!;
    public string? DocumentoComentarioCodigo { get; set; }
    public string Comentario { get; set; } = null!;
    public bool Recordar { get; set; }
    public int IdDocumento { get; set; }
    public string DocDocumentoDocumento { get; set; } = null!;
    public string? DocDocumentoDocumentoCodigo { get; set; }
    public int DocDocumentoDocumentoNumero { get; set; }
    public string DocDocumentoPrefijo { get; set; } = null!;
    public double DocDocumentoSubtotal { get; set; }
    public double DocDocumentoDescuento { get; set; }
    public double DocDocumentoIva { get; set; }
    public double DocDocumentoTotal { get; set; }
    public double DocDocumentoCosto { get; set; }
    public double DocDocumentoRentabilidad { get; set; }
    public double DocDocumentoTrm { get; set; }
    public DateTime DocDocumentoFechaFh { get; set; }
    public DateTime DocDocumentoFechaSugeridaFh { get; set; }
    public DateTime DocDocumentoFechaCierreFf { get; set; }
    public DateTime DocDocumentoFechaLimiteFh { get; set; }
    public int DocDocumentoIdSubtipoDocumento { get; set; }
    public int DocDocumentoIdTerceroCliente { get; set; }
    public int DocDocumentoIdDocumento { get; set; }
    public int DocDocumentoIdTerceroProveedor { get; set; }
    public int DocDocumentoIdPrioridadDocumento { get; set; }
    public int DocDocumentoIdMoneda { get; set; }
    public int DocDocumentoIdEstadoTipoDocumento { get; set; }
    public int DocDocumentoIdMotivoestado { get; set; }
    public double DocDocumentoSubtotalPlaneado { get; set; }
    public double DocDocumentoDescuentoPlaneado { get; set; }
    public double DocDocumentoIvaPlaneado { get; set; }
    public double DocDocumentoTotalPlaneado { get; set; }
    public double DocDocumentoCostoPlaneado { get; set; }
    public int DocDocumentoIdUsuarioAsignado { get; set; }
    public int DocDocumentoIdUsuarioEnUso { get; set; }
    public int IdUsuario { get; set; }
    public string SegUsuarioUsuario { get; set; } = null!;
    public string? SegUsuarioUsuarioCodigo { get; set; }
    public int? SegUsuarioIntentosFallidos { get; set; }
    public int? SegUsuarioNumeroIngresos { get; set; }
    public DateTime? SegUsuarioFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioClave { get; set; }
    public string? SegUsuarioNombre { get; set; }
    public string? SegUsuarioProfesion { get; set; }
    public string SegUsuarioEmail { get; set; } = null!;
    public string? SegUsuarioDireccion { get; set; }
    public string? SegUsuarioTelefono { get; set; }
    public decimal? SegUsuarioCostoHora { get; set; }
    public double? SegUsuarioPorcentajeComision { get; set; }
    public bool? SegUsuarioAccesoActivo { get; set; }
    public bool? SegUsuarioCambiarClave { get; set; }
    public DateTime? SegUsuarioFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioAplicaRecargo { get; set; }
    public bool SegUsuarioSexo { get; set; }
    public int SegUsuarioIdPerfil { get; set; }
    public int SegUsuarioIdCargo { get; set; }
    public int SegUsuarioIdGrupo { get; set; }
    public int SegUsuarioIdZona { get; set; }
    public string? SegUsuarioIdentificacion { get; set; }
    public int SegUsuarioIdUsuario { get; set; }
    public byte[]? SegUsuarioPreferencias { get; set; }
    public bool SegUsuarioHabilitado { get; set; }
    public string? SegUsuarioCreoNombre { get; set; }
    public int IdTarea { get; set; }
    public string DocTareaTarea { get; set; } = null!;
    public string? DocTareaTareaCodigo { get; set; }
    public int DocTareaIdCatalogo { get; set; }
    public int DocTareaIdCargo { get; set; }
    public DateTime DocTareaFechaPlaneadaFh { get; set; }
    public int DocTareaPorcentajeAvance { get; set; }
    public int DocTareaIdDocumento { get; set; }
    public DateTime FechaRecordarFh { get; set; }
    public bool Cerrada { get; set; }
    public int IdDocumentoComentario { get; set; }
    public string DocDocumentoComentarioPadreDocumentoComentario { get; set; } = null!;
    public string? DocDocumentoComentarioPadreDocumentoComentarioCodigo { get; set; }
    public string DocDocumentoComentarioPadreComentario { get; set; } = null!;
    public bool DocDocumentoComentarioPadreRecordar { get; set; }
    public int DocDocumentoComentarioPadreIdDocumento { get; set; }
    public int DocDocumentoComentarioPadreIdUsuario { get; set; }
    public int DocDocumentoComentarioPadreIdTarea { get; set; }
    public DateTime DocDocumentoComentarioPadreFechaRecordarFh { get; set; }
    public bool DocDocumentoComentarioPadreCerrada { get; set; }
    public int DocDocumentoComentarioPadreIdDocumentoComentario { get; set; }
    public int DocDocumentoComentarioPadreIdContacto { get; set; }
    public DateTime DocDocumentoComentarioPadreFechaOrden { get; set; }
    public DateTime DocDocumentoComentarioPadreFechaOriginal { get; set; }
    public int DocDocumentoComentarioPadreIdUsuarioOriginal { get; set; }
    public int DocDocumentoComentarioPadreConRespuesta { get; set; }
    public int DocDocumentoComentarioPadreRelevante { get; set; }
    public int DocDocumentoComentarioPadreIdReporteTecnico { get; set; }
    public int DocDocumentoComentarioPadreFinalizado { get; set; }
    public int IdContacto { get; set; }
    public string TerContactoContacto { get; set; } = null!;
    public string? TerContactoContactoCodigo { get; set; }
    public string TerContactoTelefono { get; set; } = null!;
    public string? TerContactoFax { get; set; }
    public string? TerContactoEmail { get; set; }
    public string? TerContactoDireccion { get; set; }
    public string? TerContactoTelefonoMovil { get; set; }
    public int TerContactoIdTercero { get; set; }
    public int TerContactoIdUsuario { get; set; }
    public string? TerContactoCargo { get; set; }
    public string? TerContactoCodigoAcceso { get; set; }
    public int? TerContactoIdCargoContacto { get; set; }
    public bool TerContactoAccesoActivo { get; set; }
    public string TerTerceroCliente { get; set; } = null!;
    public DateTime FechaOrden { get; set; }
    public DateTime FechaOriginal { get; set; }
    public int IdUsuarioOriginal { get; set; }
    public int ConRespuesta { get; set; }
    public int Relevante { get; set; }
    public int IdReporteTecnico { get; set; }
    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;
    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }
    public string? OrtReporteTecnicoNumero { get; set; }
    public string? OrtReporteTecnicoTrabajos { get; set; }
    public string? OrtReporteTecnicoRecomendaciones { get; set; }
    public string? OrtReporteTecnicoCompromisos { get; set; }
    public int OrtReporteTecnicoIdGasto { get; set; }
    public int Finalizado { get; set; }
    public string Multiempresa { get; set; } = null!;
}
