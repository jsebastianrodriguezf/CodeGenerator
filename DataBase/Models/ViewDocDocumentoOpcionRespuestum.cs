using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoOpcionRespuestum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOpcionRespuesta { get; set; } = null!;

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

    public int IdOpcionRespuesta { get; set; }

    public string DocOpcionRespuestaOpcionRespuesta { get; set; } = null!;

    public string? DocOpcionRespuestaOpcionRespuestaCodigo { get; set; }

    public int DocOpcionRespuestaOrden { get; set; }

    public bool DocOpcionRespuestaActiva { get; set; }

    public int DocOpcionRespuestaValor { get; set; }

    public int DocOpcionRespuestaIdPregunta { get; set; }

    public int IdPregunta { get; set; }

    public string DocPreguntaPregunta { get; set; } = null!;

    public string? DocPreguntaPreguntaCodigo { get; set; }

    public int DocPreguntaOrden { get; set; }

    public bool DocPreguntaActiva { get; set; }

    public int DocPreguntaValor { get; set; }

    public int DocPreguntaIdEvaluacion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
