using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocDocumentoCotizacionCondicion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoCotizacionCondicion { get; set; } = null!;

    public bool? Imprimir { get; set; }

    public int IdOpcionCondicion { get; set; }

    public string DocOpcionCondicionOpcionCondicion { get; set; } = null!;

    public string? DocOpcionCondicionOpcionCondicionCodigo { get; set; }

    public int DocOpcionCondicionIdCondicion { get; set; }

    public int IdDocumentoCotizacion { get; set; }

    public string DocDocumentoCotizacionDocumentoCotizacion { get; set; } = null!;

    public int DocDocumentoCotizacionVersion { get; set; }

    public int DocDocumentoCotizacionValidez { get; set; }

    public string DocDocumentoCotizacionContacto { get; set; } = null!;

    public string DocDocumentoCotizacionCargo { get; set; } = null!;

    public string DocDocumentoCotizacionEncabezado { get; set; } = null!;

    public string DocDocumentoCotizacionCondiciones { get; set; } = null!;

    public string DocDocumentoCotizacionNotas { get; set; } = null!;

    public bool DocDocumentoCotizacionEsAiu { get; set; }

    public double? DocDocumentoCotizacionProcentajeA { get; set; }

    public double? DocDocumentoCotizacionProcentajeI { get; set; }

    public double? DocDocumentoCotizacionProcentajeU { get; set; }

    public double? DocDocumentoCotizacionValorA { get; set; }

    public double? DocDocumentoCotizacionValorI { get; set; }

    public double? DocDocumentoCotizacionValorU { get; set; }

    public int DocDocumentoCotizacionIdSucursal { get; set; }

    public int DocDocumentoCotizacionIdEquipo { get; set; }

    public int DocDocumentoCotizacionIdUsuarioAsesor { get; set; }

    public string? DocDocumentoCotizacionEmail { get; set; }

    public string? DocDocumentoCotizacionDocumentoCodigo { get; set; }

    public int DocDocumentoCotizacionDocumentoNumero { get; set; }

    public string DocDocumentoCotizacionPrefijo { get; set; } = null!;

    public double DocDocumentoCotizacionSubtotal { get; set; }

    public double DocDocumentoCotizacionDescuento { get; set; }

    public double DocDocumentoCotizacionIva { get; set; }

    public double DocDocumentoCotizacionTotal { get; set; }

    public double DocDocumentoCotizacionCosto { get; set; }

    public double DocDocumentoCotizacionRentabilidad { get; set; }

    public double DocDocumentoCotizacionTrm { get; set; }

    public DateTime DocDocumentoCotizacionFechaFh { get; set; }

    public DateTime DocDocumentoCotizacionFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoCotizacionFechaCierreFf { get; set; }

    public DateTime DocDocumentoCotizacionFechaLimiteFh { get; set; }

    public int DocDocumentoCotizacionIdSubtipoDocumento { get; set; }

    public int DocDocumentoCotizacionIdTerceroCliente { get; set; }

    public int DocDocumentoCotizacionIdDocumento { get; set; }

    public int DocDocumentoCotizacionIdTerceroProveedor { get; set; }

    public int DocDocumentoCotizacionIdPrioridadDocumento { get; set; }

    public int DocDocumentoCotizacionIdMoneda { get; set; }

    public int DocDocumentoCotizacionIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoCotizacionIdMotivoestado { get; set; }

    public double DocDocumentoCotizacionSubtotalPlaneado { get; set; }

    public double DocDocumentoCotizacionDescuentoPlaneado { get; set; }

    public double DocDocumentoCotizacionIvaPlaneado { get; set; }

    public double DocDocumentoCotizacionTotalPlaneado { get; set; }

    public double DocDocumentoCotizacionCostoPlaneado { get; set; }

    public int DocDocumentoCotizacionIdUsuarioAsignado { get; set; }

    public int DocDocumentoCotizacionIdUsuarioEnUso { get; set; }

    public int IdCondicion { get; set; }

    public string DocCondicionCondicion { get; set; } = null!;

    public string? DocCondicionCondicionCodigo { get; set; }

    public bool DocCondicionTextoLibre { get; set; }

    public string Multiempresa { get; set; } = null!;
}
