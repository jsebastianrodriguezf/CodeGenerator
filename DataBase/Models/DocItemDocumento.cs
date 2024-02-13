using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocItemDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ItemDocumento { get; set; } = null!;

    public string? ItemDocumentoCodigo { get; set; }

    public string Detalle { get; set; } = null!;

    public double HorasOrdinales { get; set; }

    public double HorasFestivas { get; set; }

    public double HorasNocturnas { get; set; }

    public double CantidadPlaneado { get; set; }

    public double CantidadEjecutado { get; set; }

    public decimal ValorUnitarioPlaneado { get; set; }

    public decimal ValorUnitarioEjecutado { get; set; }

    public decimal SubtotalPlaneado { get; set; }

    public decimal SubtotalEjecutado { get; set; }

    public decimal TotalPlaneado { get; set; }

    public decimal TotalEjecutado { get; set; }

    public double Porciva { get; set; }

    public decimal IvaPlaneado { get; set; }

    public decimal IvaEjecutado { get; set; }

    public double Porcdto { get; set; }

    public decimal DtoPlaneado { get; set; }

    public decimal DtoEjecutado { get; set; }

    public bool Costear { get; set; }

    public bool EsUrgente { get; set; }

    public DateTime? VencimientoGarantiaFf { get; set; }

    public double? HorasGarantia { get; set; }

    public double? PorcentajeCliente { get; set; }

    public double? PorcentajeDistribuidor { get; set; }

    public double? PorcentajeFabricante { get; set; }

    public bool AfectoInventario { get; set; }

    public int IdDocumento { get; set; }

    public int IdItemDocumento { get; set; }

    public int IdCentroCosto { get; set; }

    public int IdCatalogo { get; set; }

    public int IdBodega { get; set; }

    public int IdIncoterm { get; set; }

    public int IdItemDocumentoSuperior { get; set; }

    public double CostoPlaneado { get; set; }

    public double CostoEjecutado { get; set; }

    public int IdListaprecio { get; set; }

    public double? Vrbase { get; set; }

    public double? Vrenlista { get; set; }

    public double? Porcdescuento { get; set; }

    public double CantAuxiliar { get; set; }

    public double? PorcentajeMargen { get; set; }

    public double? MargenPlaneado { get; set; }

    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();

    public virtual ICollection<AlqDetallealquilerItemdocumento> AlqDetallealquilerItemdocumentos { get; set; } = new List<AlqDetallealquilerItemdocumento>();

    public virtual ICollection<AlqTarifa> AlqTarifas { get; set; } = new List<AlqTarifa>();

    public virtual ICollection<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; } = new List<DocDocumentoCatalogoTempario>();

    public virtual ICollection<DocPendienteDocumentoDocItemDocumento> DocPendienteDocumentoDocItemDocumentos { get; set; } = new List<DocPendienteDocumentoDocItemDocumento>();

    public virtual ICollection<DocSoporteItemDocumento> DocSoporteItemDocumentos { get; set; } = new List<DocSoporteItemDocumento>();

    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();

    public virtual ICollection<EquEquipoItemDocumento> EquEquipoItemDocumentos { get; set; } = new List<EquEquipoItemDocumento>();

    public virtual ICollection<GasDocumentoOtDetalleGasto> GasDocumentoOtDetalleGastos { get; set; } = new List<GasDocumentoOtDetalleGasto>();

    public virtual GenBodega IdBodegaNavigation { get; set; } = null!;

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual DocCentroCosto IdCentroCostoNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual DocIncoterm IdIncotermNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemDocumentoSuperiorNavigation { get; set; } = null!;

    public virtual CatListaPrecio IdListaprecioNavigation { get; set; } = null!;

    public virtual ICollection<DocItemDocumento> InverseIdItemDocumentoNavigation { get; set; } = new List<DocItemDocumento>();

    public virtual ICollection<DocItemDocumento> InverseIdItemDocumentoSuperiorNavigation { get; set; } = new List<DocItemDocumento>();
}
