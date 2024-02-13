namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogo : CatCatalogoObject
{
    public virtual ICollection<CatCatalogoBodega> CatCatalogoBodegas { get; set; } = new List<CatCatalogoBodega>();
    public virtual ICollection<CatCatalogoListaPrecio> CatCatalogoListaPrecios { get; set; } = new List<CatCatalogoListaPrecio>();
    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();
    public virtual ICollection<CntContratoCatalogo> CntContratoCatalogos { get; set; } = new List<CntContratoCatalogo>();
    public virtual ICollection<CntVisitaFijaCatalogo> CntVisitaFijaCatalogos { get; set; } = new List<CntVisitaFijaCatalogo>();
    public virtual ICollection<DisEventoCatalogo> DisEventoCatalogos { get; set; } = new List<DisEventoCatalogo>();
    public virtual ICollection<DisObraCatalogo> DisObraCatalogos { get; set; } = new List<DisObraCatalogo>();
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
    public virtual ICollection<DocPendienteDocumento> DocPendienteDocumentos { get; set; } = new List<DocPendienteDocumento>();
    public virtual ICollection<DocTarea> DocTareas { get; set; } = new List<DocTarea>();
    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();
    public virtual ICollection<EquEquipoItemDocumento> EquEquipoItemDocumentos { get; set; } = new List<EquEquipoItemDocumento>();
    public virtual ICollection<GasDetalleGasto> GasDetalleGastos { get; set; } = new List<GasDetalleGasto>();
    public virtual ICollection<GenConfiguracionServicio> GenConfiguracionServicios { get; set; } = new List<GenConfiguracionServicio>();
    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;
    public virtual GenImpuesto IdImpuestoNavigation { get; set; } = null!;
    public virtual CatSubtipoCatalogo IdSubtipoCatalogoNavigation { get; set; } = null!;
    public virtual GenUnidad IdUnidadNavigation { get; set; } = null!;
    public virtual ICollection<LicCatalogoParametro> LicCatalogoParametros { get; set; } = new List<LicCatalogoParametro>();
    public virtual ICollection<LicLicencium> LicLicencia { get; set; } = new List<LicLicencium>();
    public virtual ICollection<ProRecursoFisico> ProRecursoFisicos { get; set; } = new List<ProRecursoFisico>();
}
