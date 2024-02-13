using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoEstadoTipoDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoEstadoTipoDocumento { get; set; } = null!;

    public string? Notas { get; set; }

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

    public int IdMotivoestado { get; set; }

    public string DocMotivoestadoMotivoestado { get; set; } = null!;

    public string? DocMotivoestadoMotivoestadoCodigo { get; set; }

    public int DocMotivoestadoIdEstadoTipoDocumento { get; set; }

    public string Multiempresa { get; set; } = null!;
}
