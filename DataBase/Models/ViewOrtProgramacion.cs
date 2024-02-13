using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewOrtProgramacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Programacion { get; set; } = null!;

    public string? ProgramacionCodigo { get; set; }

    public DateTime? DesdeFh { get; set; }

    public double? Duracion { get; set; }

    public string? Comentario { get; set; }

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

    public int IdTipoProgramacion { get; set; }

    public string OrtTipoProgramacionTipoProgramacion { get; set; } = null!;

    public string? OrtTipoProgramacionTipoProgramacionCodigo { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public string OrtMotivoCancelacionMotivoCancelacion { get; set; } = null!;

    public string? OrtMotivoCancelacionMotivoCancelacionCodigo { get; set; }

    public bool? OrtMotivoCancelacionResponsableServicio { get; set; }

    public int IdDocumentoOt { get; set; }

    public string DocDocumentoOtDocumentoOt { get; set; } = null!;

    public string DocDocumentoOtMotivoServicio { get; set; } = null!;

    public bool DocDocumentoOtEnTaller { get; set; }

    public string? DocDocumentoOtDiagnosticoInicial { get; set; }

    public string DocDocumentoOtContacto { get; set; } = null!;

    public string? DocDocumentoOtCargo { get; set; }

    public string DocDocumentoOtTelefono { get; set; } = null!;

    public string? DocDocumentoOtFax { get; set; }

    public string? DocDocumentoOtEmail { get; set; }

    public string? DocDocumentoOtDireccionUbicacion { get; set; }

    public double DocDocumentoOtDuracionEstimada { get; set; }

    public DateTime? DocDocumentoOtFechaGarantiaFf { get; set; }

    public DateTime DocDocumentoOtFechaCompromisoFh { get; set; }

    public string? DocDocumentoOtTrabajos { get; set; }

    public string? DocDocumentoOtRecomendaciones { get; set; }

    public string? DocDocumentoOtCompromisos { get; set; }

    public string? DocDocumentoOtReclamacionFabrica { get; set; }

    public double? DocDocumentoOtPorcentajeCliente { get; set; }

    public double? DocDocumentoOtPorcentajeDistribuidor { get; set; }

    public double? DocDocumentoOtPorcentajeFabricante { get; set; }

    public bool? DocDocumentoOtSegunTempario { get; set; }

    public bool? DocDocumentoOtDistribuyeCentros { get; set; }

    public int DocDocumentoOtIdTipoServicio { get; set; }

    public int DocDocumentoOtIdEquipo { get; set; }

    public int DocDocumentoOtIdUsuarioCoordinador { get; set; }

    public int DocDocumentoOtIdMotivoCancelacion { get; set; }

    public int DocDocumentoOtIdSucursal { get; set; }

    public int DocDocumentoOtIdSistema { get; set; }

    public int DocDocumentoOtIdDepartamentoSolicitud { get; set; }

    public int DocDocumentoOtIdContrato { get; set; }

    public int DocDocumentoOtIdZona { get; set; }

    public string? DocDocumentoOtDocumentoCodigo { get; set; }

    public int DocDocumentoOtDocumentoNumero { get; set; }

    public string DocDocumentoOtPrefijo { get; set; } = null!;

    public double DocDocumentoOtSubtotal { get; set; }

    public double DocDocumentoOtDescuento { get; set; }

    public double DocDocumentoOtIva { get; set; }

    public double DocDocumentoOtTotal { get; set; }

    public double DocDocumentoOtCosto { get; set; }

    public double DocDocumentoOtRentabilidad { get; set; }

    public double DocDocumentoOtTrm { get; set; }

    public DateTime DocDocumentoOtFechaFh { get; set; }

    public DateTime DocDocumentoOtFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoOtFechaCierreFf { get; set; }

    public DateTime DocDocumentoOtFechaLimiteFh { get; set; }

    public int DocDocumentoOtIdSubtipoDocumento { get; set; }

    public int DocDocumentoOtIdTerceroCliente { get; set; }

    public int DocDocumentoOtIdDocumento { get; set; }

    public int DocDocumentoOtIdTerceroProveedor { get; set; }

    public int DocDocumentoOtIdPrioridadDocumento { get; set; }

    public int DocDocumentoOtIdMoneda { get; set; }

    public int DocDocumentoOtIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoOtIdMotivoestado { get; set; }

    public double DocDocumentoOtSubtotalPlaneado { get; set; }

    public double DocDocumentoOtDescuentoPlaneado { get; set; }

    public double DocDocumentoOtIvaPlaneado { get; set; }

    public double DocDocumentoOtTotalPlaneado { get; set; }

    public double DocDocumentoOtCostoPlaneado { get; set; }

    public int IdProgramacion { get; set; }

    public string OrtProgramacionPadreProgramacion { get; set; } = null!;

    public string? OrtProgramacionPadreProgramacionCodigo { get; set; }

    public DateTime? OrtProgramacionPadreDesdeFh { get; set; }

    public double? OrtProgramacionPadreDuracion { get; set; }

    public string? OrtProgramacionPadreComentario { get; set; }

    public int OrtProgramacionPadreIdUsuario { get; set; }

    public int OrtProgramacionPadreIdTipoProgramacion { get; set; }

    public int OrtProgramacionPadreIdMotivoCancelacion { get; set; }

    public int OrtProgramacionPadreIdDocumentoOt { get; set; }

    public int OrtProgramacionPadreIdProgramacion { get; set; }

    public int OrtProgramacionPadreIdReporteTecnico { get; set; }

    public int OrtProgramacionPadreIdCatalogoActividad { get; set; }

    public double OrtProgramacionPadreCosto { get; set; }

    public int OrtProgramacionPadreIdSoporteItemDocumento { get; set; }

    public int IdReporteTecnico { get; set; }

    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;

    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }

    public string? OrtReporteTecnicoNumero { get; set; }

    public string? OrtReporteTecnicoTrabajos { get; set; }

    public string? OrtReporteTecnicoRecomendaciones { get; set; }

    public string? OrtReporteTecnicoCompromisos { get; set; }

    public int OrtReporteTecnicoIdGasto { get; set; }

    public int IdCatalogoActividad { get; set; }

    public string CatCatalogoActividadCatalogoActividad { get; set; } = null!;

    public bool? CatCatalogoActividadEsProductiva { get; set; }

    public double? CatCatalogoActividadDuracionEstimada { get; set; }

    public string? CatCatalogoActividadProcedimiento { get; set; }

    public string? CatCatalogoActividadCatalogoCodigo { get; set; }

    public string CatCatalogoActividadCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoActividadPrecioVenta { get; set; }

    public int? CatCatalogoActividadTiempoConsecucion { get; set; }

    public bool CatCatalogoActividadEsNacional { get; set; }

    public int CatCatalogoActividadIdFamilia { get; set; }

    public int CatCatalogoActividadIdSubTipoCatalogo { get; set; }

    public int CatCatalogoActividadIdUnidad { get; set; }

    public int CatCatalogoActividadIdImpuesto { get; set; }

    public string CatCatalogoActividadDescripcion { get; set; } = null!;

    public bool CatCatalogoActividadBloquearCostear { get; set; }

    public double Costo { get; set; }

    public int IdSoporteItemDocumento { get; set; }

    public string DocSoporteItemDocumentoSoporteItemDocumento { get; set; } = null!;

    public string? DocSoporteItemDocumentoSoporteItemDocumentoCodigo { get; set; }

    public double DocSoporteItemDocumentoDuracionPlaneada { get; set; }

    public decimal DocSoporteItemDocumentoValor { get; set; }

    public decimal DocSoporteItemDocumentoCosto { get; set; }

    public int DocSoporteItemDocumentoIdItemDocumento { get; set; }

    public int DocSoporteItemDocumentoIdUsuario { get; set; }

    public double DocSoporteItemDocumentoDuracionEjecutada { get; set; }

    public DateTime? HastaFh { get; set; }

    public string SegUsuarioCargo { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
