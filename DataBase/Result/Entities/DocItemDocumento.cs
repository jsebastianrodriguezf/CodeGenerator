namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocItemDocumento : DocItemDocumentoObject
{
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
