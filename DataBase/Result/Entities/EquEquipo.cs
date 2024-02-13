namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquEquipo : EquEquipoObject
{
    public virtual ICollection<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; } = new List<AlqHistoricoAlquiler>();
    public virtual ICollection<CntContratoEquipo> CntContratoEquipos { get; set; } = new List<CntContratoEquipo>();
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
    public virtual ICollection<DisObraEquipo> DisObraEquipos { get; set; } = new List<DisObraEquipo>();
    public virtual ICollection<DocDocumentoCotizacion> DocDocumentoCotizacions { get; set; } = new List<DocDocumentoCotizacion>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; } = new List<DocDocumentoSolicitud>();
    public virtual ICollection<EquCicloHorometro> EquCicloHorometros { get; set; } = new List<EquCicloHorometro>();
    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();
    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();
    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();
    public virtual ICollection<EquEquipoItemDocumento> EquEquipoItemDocumentos { get; set; } = new List<EquEquipoItemDocumento>();
    public virtual ICollection<EquOverhall> EquOverhalls { get; set; } = new List<EquOverhall>();
    public virtual ICollection<EquPrestamoEquipo> EquPrestamoEquipos { get; set; } = new List<EquPrestamoEquipo>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidadIdEquipoNavigations { get; set; } = new List<EquTrazabilidad>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidadIdEquipoPadreNavigations { get; set; } = new List<EquTrazabilidad>();
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual EquEstadoEquipo IdEstadoEquipoNavigation { get; set; } = null!;
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroCompradorNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroServicioNavigation { get; set; } = null!;
    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
    public virtual ICollection<EquEquipo> InverseIdEquipoNavigation { get; set; } = new List<EquEquipo>();
    public virtual ICollection<ProRecursoFisico> ProRecursoFisicos { get; set; } = new List<ProRecursoFisico>();
    public virtual ICollection<TerContactoEquipo> TerContactoEquipos { get; set; } = new List<TerContactoEquipo>();
}
