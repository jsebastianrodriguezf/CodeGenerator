using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewOrtReporteTecnicoOt
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public int IdReporteTecnico { get; set; }

    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;

    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }

    public string? OrtReporteTecnicoNumero { get; set; }

    public string? OrtReporteTecnicoTrabajos { get; set; }

    public string? OrtReporteTecnicoRecomendaciones { get; set; }

    public string? OrtReporteTecnicoCompromisos { get; set; }

    public int OrtReporteTecnicoIdGasto { get; set; }

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

    public string DocDocumentoOtDireccionUbicacion { get; set; } = null!;

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

    public string Observaciones { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
