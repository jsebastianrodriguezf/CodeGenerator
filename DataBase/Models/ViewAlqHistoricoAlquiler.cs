using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewAlqHistoricoAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string HistoricoAlquiler { get; set; } = null!;

    public string? HistoricoAlquilerCodigo { get; set; }

    public int? IdEquipo { get; set; }

    public string EquEquipoEquipo { get; set; } = null!;

    public string? EquEquipoEquipoCodigo { get; set; }

    public string EquEquipoEquipoSerial { get; set; } = null!;

    public string? EquEquipoNombreContacto { get; set; }

    public string? EquEquipoTelefonoContacto { get; set; }

    public string? EquEquipoUbicacion { get; set; }

    public string? EquEquipoObservaciones { get; set; }

    public DateTime? EquEquipoFechaPuestaMarchaFh { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaFabricaFf { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaDistribuidorFf { get; set; }

    public double? EquEquipoHorasGarantia { get; set; }

    public DateTime? EquEquipoUltimaLecturaFh { get; set; }

    public double EquEquipoHorometroActual { get; set; }

    public double EquEquipoPromedioHoras { get; set; }

    public decimal? EquEquipoCosto { get; set; }

    public DateTime? EquEquipoFechaImportacionFf { get; set; }

    public string? EquEquipoGarantiaCancelada { get; set; }

    public int EquEquipoIdCatalogoEquipo { get; set; }

    public int EquEquipoIdSistema { get; set; }

    public int EquEquipoIdSucursal { get; set; }

    public int EquEquipoIdZona { get; set; }

    public int EquEquipoIdVersionEquipo { get; set; }

    public int EquEquipoIdTerceroComprador { get; set; }

    public int EquEquipoIdTercero { get; set; }

    public int EquEquipoIdTerceroServicio { get; set; }

    public int EquEquipoIdEquipo { get; set; }

    public int EquEquipoIdEstadoEquipo { get; set; }

    public int EquEquipoIdCentroCosto { get; set; }

    public int? IdEstadoEquipo { get; set; }

    public string EquEstadoEquipoEstadoEquipo { get; set; } = null!;

    public string? EquEstadoEquipoEstadoEquipoCodigo { get; set; }

    public bool EquEstadoEquipoActivo { get; set; }

    public int? IdDocumento { get; set; }

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

    public DateTime FechaEstado { get; set; }

    public string Multiempresa { get; set; } = null!;
}
