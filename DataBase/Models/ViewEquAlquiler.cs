using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Alquiler { get; set; } = null!;

    public string? AlquilerCodigo { get; set; }

    public DateTime FechaCompromisoFf { get; set; }

    public int IdSucursal { get; set; }

    public string TerSucursalSucursal { get; set; } = null!;

    public string? TerSucursalSucursalCodigo { get; set; }

    public string? TerSucursalContacto { get; set; }

    public string TerSucursalTelefono { get; set; } = null!;

    public string? TerSucursalFax { get; set; }

    public string? TerSucursalEmail { get; set; }

    public string? TerSucursalDireccion { get; set; }

    public bool TerSucursalParaVenta { get; set; }

    public bool TerSucursalParaSoporte { get; set; }

    public bool TerSucursalParaAlquiler { get; set; }

    public int TerSucursalIdTercero { get; set; }

    public int TerSucursalIdZona { get; set; }

    public int TerSucursalIdUsuarioAsesor { get; set; }

    public int TerSucursalIdUsuarioTecnico { get; set; }

    public int TerSucursalIdSucursal { get; set; }

    public int TerSucursalIdEstadoTercero { get; set; }

    public string? TerSucursalCodigorecursiva { get; set; }

    public int IdTercero { get; set; }

    public string TerTerceroTercero { get; set; } = null!;

    public string? TerTerceroTerceroCodigo { get; set; }

    public string TerTerceroTerceroNit { get; set; } = null!;

    public string? TerTerceroDireccion { get; set; }

    public string? TerTerceroContacto { get; set; }

    public string TerTerceroTelefono { get; set; } = null!;

    public string? TerTerceroFax { get; set; }

    public string? TerTerceroEmail { get; set; }

    public string? TerTerceroWebsite { get; set; }

    public string? TerTerceroRepresentante { get; set; }

    public string? TerTerceroNotas { get; set; }

    public string TerTerceroTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroEsCliente { get; set; }

    public bool TerTerceroEsProveedor { get; set; }

    public bool TerTerceroEsTransportador { get; set; }

    public bool TerTerceroEsFabricante { get; set; }

    public bool TerTerceroEsEmpresaPropia { get; set; }

    public string? TerTerceroClasificacion { get; set; }

    public int TerTerceroIdZona { get; set; }

    public int TerTerceroIdEstadoTercero { get; set; }

    public int TerTerceroIdNaturalezaTercero { get; set; }

    public bool TerTerceroEsProspecto { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public string DocSubtipoDocumentoSubtipoDocumento { get; set; } = null!;

    public string? DocSubtipoDocumentoSubtipoDocumentoCodigo { get; set; }

    public string DocSubtipoDocumentoPrefijo { get; set; } = null!;

    public int DocSubtipoDocumentoConsecutivo { get; set; }

    public int DocSubtipoDocumentoIdTipoDocumento { get; set; }

    public bool DocSubtipoDocumentoProgramarPlaneadas { get; set; }

    public DateTime? FechaFinFf { get; set; }

    public bool MesVencido { get; set; }

    public int AlquilerNumero { get; set; }

    public string? Observaciones { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
