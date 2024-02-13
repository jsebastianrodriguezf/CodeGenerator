using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocTarea
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Tarea { get; set; } = null!;

    public string? TareaCodigo { get; set; }

    public int IdCatalogo { get; set; }

    public string CatCatalogoCatalogo { get; set; } = null!;

    public string? CatCatalogoCatalogoCodigo { get; set; }

    public string CatCatalogoCodigoInventario { get; set; } = null!;

    public decimal? CatCatalogoPrecioVenta { get; set; }

    public int? CatCatalogoTiempoConsecucion { get; set; }

    public bool CatCatalogoEsNacional { get; set; }

    public int CatCatalogoIdFamilia { get; set; }

    public int CatCatalogoIdSubTipoCatalogo { get; set; }

    public int CatCatalogoIdUnidad { get; set; }

    public int CatCatalogoIdImpuesto { get; set; }

    public string CatCatalogoDescripcion { get; set; } = null!;

    public bool CatCatalogoBloquearCostear { get; set; }

    public int IdCargo { get; set; }

    public string SegCargoCargo { get; set; } = null!;

    public string? SegCargoCargoCodigo { get; set; }

    public bool? SegCargoEsTecnico { get; set; }

    public bool? SegCargoEsComercial { get; set; }

    public bool? SegCargoEsCoordinador { get; set; }

    public decimal? SegCargoValorHora { get; set; }

    public bool SegCargoEsAdministrativo { get; set; }

    public DateTime FechaPlaneadaFh { get; set; }

    public int PorcentajeAvance { get; set; }

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
