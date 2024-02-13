namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegUsuario : SegUsuarioObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();
    public virtual ICollection<DocDocumentoCotizacion> DocDocumentoCotizacions { get; set; } = new List<DocDocumentoCotizacion>();
    public virtual ICollection<DocDocumentoEntradum> DocDocumentoEntrada { get; set; } = new List<DocDocumentoEntradum>();
    public virtual ICollection<DocDocumento> DocDocumentoIdUsuarioAsignadoNavigations { get; set; } = new List<DocDocumento>();
    public virtual ICollection<DocDocumento> DocDocumentoIdUsuarioEnUsoNavigations { get; set; } = new List<DocDocumento>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<DocDocumentoSalidum> DocDocumentoSalida { get; set; } = new List<DocDocumentoSalidum>();
    public virtual ICollection<DocSoporteItemDocumento> DocSoporteItemDocumentos { get; set; } = new List<DocSoporteItemDocumento>();
    public virtual ICollection<EquPrestamo> EquPrestamos { get; set; } = new List<EquPrestamo>();
    public virtual ICollection<GasGasto> GasGastoIdUsuarioAproboNavigations { get; set; } = new List<GasGasto>();
    public virtual ICollection<GasGasto> GasGastoIdUsuarioSolicitanteNavigations { get; set; } = new List<GasGasto>();
    public virtual ICollection<GenBodegaUsuario> GenBodegaUsuarios { get; set; } = new List<GenBodegaUsuario>();
    public virtual ICollection<GenNotificacion> GenNotificacionIdUsuarioDestinoNavigations { get; set; } = new List<GenNotificacion>();
    public virtual ICollection<GenNotificacion> GenNotificacionIdUsuarioOrigenNavigations { get; set; } = new List<GenNotificacion>();
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual SegGrupo IdGrupoNavigation { get; set; } = null!;
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
    public virtual ICollection<SegUsuario> InverseIdUsuarioNavigation { get; set; } = new List<SegUsuario>();
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
    public virtual ICollection<ProEjecutore> ProEjecutores { get; set; } = new List<ProEjecutore>();
    public virtual ICollection<SegRegistroPeticion> SegRegistroPeticions { get; set; } = new List<SegRegistroPeticion>();
    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();
    public virtual ICollection<TerContactoEquipo> TerContactoEquipos { get; set; } = new List<TerContactoEquipo>();
    public virtual ICollection<TerContacto> TerContactos { get; set; } = new List<TerContacto>();
    public virtual ICollection<TerSucursal> TerSucursalIdUsuarioAsesorNavigations { get; set; } = new List<TerSucursal>();
    public virtual ICollection<TerSucursal> TerSucursalIdUsuarioTecnicoNavigations { get; set; } = new List<TerSucursal>();
    public virtual ICollection<TerSucursalUsuario> TerSucursalUsuarios { get; set; } = new List<TerSucursalUsuario>();
    public virtual ICollection<TerTerceroUsuario> TerTerceroUsuarios { get; set; } = new List<TerTerceroUsuario>();
}
