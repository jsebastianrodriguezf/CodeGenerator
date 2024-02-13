namespace SAMMAI.Transverse.Models.Objects;

public class ViewDocDocumentoProyectoCalidadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoProyectoCalidad { get; set; } = null!;
    public int IdCalidad { get; set; }
    public string ProCalidadCalidad { get; set; } = null!;
    public string? ProCalidadCalidadCodigo { get; set; }
    public int IdDocumentoProyecto { get; set; }
    public string DocDocumentoProyectoDocumentoProyecto { get; set; } = null!;
    public string DocDocumentoProyectoNombre { get; set; } = null!;
    public DateTime DocDocumentoProyectoFechaInicioEstimada { get; set; }
    public DateTime DocDocumentoProyectoFechaFinEstimada { get; set; }
    public string? DocDocumentoProyectoDescripcion { get; set; }
    public decimal? DocDocumentoProyectoPresupuesto { get; set; }
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
    public int DocDocumentoProyectoIdUsuarioAsignado { get; set; }
    public int DocDocumentoProyectoIdUsuarioEnUso { get; set; }
    public string Multiempresa { get; set; } = null!;
}
