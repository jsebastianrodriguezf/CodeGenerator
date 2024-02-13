namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContrato : CntContratoObject
{
    public virtual ICollection<CntContratoCatalogo> CntContratoCatalogos { get; set; } = new List<CntContratoCatalogo>();
    public virtual ICollection<CntContratoDetalleVisitum> CntContratoDetalleVisita { get; set; } = new List<CntContratoDetalleVisitum>();
    public virtual ICollection<CntContratoEquipo> CntContratoEquipos { get; set; } = new List<CntContratoEquipo>();
    public virtual ICollection<CntContratoSucursal> CntContratoSucursals { get; set; } = new List<CntContratoSucursal>();
    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();
    public virtual ICollection<CntContratoZona> CntContratoZonas { get; set; } = new List<CntContratoZona>();
    public virtual ICollection<CntPagosContrato> CntPagosContratos { get; set; } = new List<CntPagosContrato>();
    public virtual ICollection<CntTiempoRespuestum> CntTiempoRespuesta { get; set; } = new List<CntTiempoRespuestum>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;
    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoInicialNavigation { get; set; } = null!;
    public virtual CntPeriodoContrato IdPeriodoContratoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoSolicitudNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroServicioNavigation { get; set; } = null!;
    public virtual CntTipoContrato IdTipoContratoNavigation { get; set; } = null!;
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioCoordinadorNavigation { get; set; } = null!;
}
