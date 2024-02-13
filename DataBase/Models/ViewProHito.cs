using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProHito
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Hito { get; set; } = null!;

    public string? HitoCodigo { get; set; }

    public int IdDocumentoProyecto { get; set; }

    public string DocDocumentoProyectoDocumentoProyecto { get; set; } = null!;

    public string? DocDocumentoProyectoDocumentoCodigo { get; set; }

    public int DocDocumentoProyectoDocumentoNumero { get; set; }

    public string DocDocumentoProyectoPrefijo { get; set; } = null!;

    public double DocDocumentoProyectoSubtotal { get; set; }

    public double DocDocumentoProyectoDescuento { get; set; }

    public double DocDocumentoProyectoIva { get; set; }

    public double DocDocumentoProyectoTotal { get; set; }

    public double DocDocumentoProyectoCosto { get; set; }

    public double DocDocumentoProyectoRentabilidad { get; set; }

    public double DocDocumentoProyectoTrm { get; set; }

    public DateTime DocDocumentoProyectoFechaFh { get; set; }

    public DateTime DocDocumentoProyectoFechaSugeridaFh { get; set; }

    public DateTime DocDocumentoProyectoFechaCierreFf { get; set; }

    public DateTime DocDocumentoProyectoFechaLimiteFh { get; set; }

    public int DocDocumentoProyectoIdSubtipoDocumento { get; set; }

    public int DocDocumentoProyectoIdTerceroCliente { get; set; }

    public int DocDocumentoProyectoIdDocumento { get; set; }

    public int DocDocumentoProyectoIdTerceroProveedor { get; set; }

    public int DocDocumentoProyectoIdPrioridadDocumento { get; set; }

    public int DocDocumentoProyectoIdMoneda { get; set; }

    public int DocDocumentoProyectoIdEstadoTipoDocumento { get; set; }

    public int DocDocumentoProyectoIdMotivoestado { get; set; }

    public double DocDocumentoProyectoSubtotalPlaneado { get; set; }

    public double DocDocumentoProyectoDescuentoPlaneado { get; set; }

    public double DocDocumentoProyectoIvaPlaneado { get; set; }

    public double DocDocumentoProyectoTotalPlaneado { get; set; }

    public double DocDocumentoProyectoCostoPlaneado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
