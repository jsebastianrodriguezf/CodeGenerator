using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquDetalleAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetalleAlquiler { get; set; } = null!;

    public string? DetalleAlquilerCodigo { get; set; }

    public DateTime FechaDevolucionFf { get; set; }

    public decimal ValorHora { get; set; }

    public decimal ValorHoraStandBy { get; set; }

    public decimal ValorPeriodo { get; set; }

    public decimal ValorMulta { get; set; }

    public DateTime FechaDespachoFf { get; set; }

    public int IdEquipo { get; set; }

    public int IdDocumentoAlquiler { get; set; }

    public int IdSucursal { get; set; }

    public int IdTercero { get; set; }

    public DateTime? FechaUltimaFacturaFh { get; set; }

    public double? ValorMes { get; set; }

    public DateTime FechaInicioFacturaFh { get; set; }

    public int CantidadSolicitada { get; set; }

    public int CantidadAlquilada { get; set; }

    public int IdCatalogo { get; set; }

    public int? Estadoalquiler { get; set; }

    public bool EsSerializado { get; set; }

    public bool BloquearDespacho { get; set; }

    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();

    public virtual ICollection<AlqDetallealquilerItemdocumento> AlqDetallealquilerItemdocumentos { get; set; } = new List<AlqDetallealquilerItemdocumento>();

    public virtual ICollection<AlqTarifa> AlqTarifas { get; set; } = new List<AlqTarifa>();

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
