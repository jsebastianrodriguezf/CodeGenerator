using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCntContratoSucursal
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContratoSucursal { get; set; } = null!;

    public decimal PrecioVisita { get; set; }

    public decimal PrecioServicio { get; set; }

    public int IdContrato { get; set; }

    public string CntContratoContrato { get; set; } = null!;

    public string? CntContratoContratoCodigo { get; set; }

    public string CntContratoNumero { get; set; } = null!;

    public decimal? CntContratoTotalContrato { get; set; }

    public decimal? CntContratoPresupuesto { get; set; }

    public DateTime CntContratoFechaInicioFf { get; set; }

    public DateTime? CntContratoFechaFinFf { get; set; }

    public int? CntContratoDiasCumplimiento { get; set; }

    public string? CntContratoCondiciones { get; set; }

    public int CntContratoIdPeriodoContrato { get; set; }

    public int CntContratoIdTercero { get; set; }

    public int CntContratoIdTipoServicio { get; set; }

    public int CntContratoIdTipoContrato { get; set; }

    public int CntContratoIdTerceroServicio { get; set; }

    public int CntContratoIdSubtipoDocumento { get; set; }

    public int CntContratoIdDepartamentoSolicitud { get; set; }

    public int CntContratoIdUsuarioCoordinador { get; set; }

    public int CntContratoIdDocumentoAlquiler { get; set; }

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

    public decimal? Presupuesto { get; set; }

    public string Multiempresa { get; set; } = null!;
}
