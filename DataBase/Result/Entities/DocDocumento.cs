namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumento : DocDocumentoObject
{
    public virtual ICollection<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; } = new List<AlqHistoricoAlquiler>();
    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();
    public virtual ICollection<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; } = new List<DocDocumentoCatalogoTempario>();
    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();
    public virtual ICollection<DocDocumentoContacto> DocDocumentoContactos { get; set; } = new List<DocDocumentoContacto>();
    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();
    public virtual ICollection<DocDocumentoEvaluacion> DocDocumentoEvaluacions { get; set; } = new List<DocDocumentoEvaluacion>();
    public virtual DocDocumentoGasto? DocDocumentoGasto { get; set; }
    public virtual ICollection<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuesta { get; set; } = new List<DocDocumentoOpcionRespuestum>();
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
    public virtual ICollection<DocPendienteDocumento> DocPendienteDocumentos { get; set; } = new List<DocPendienteDocumento>();
    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();
    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual GenMonedum IdMonedaNavigation { get; set; } = null!;
    public virtual DocMotivoestado IdMotivoestadoNavigation { get; set; } = null!;
    public virtual DocPrioridadDocumento IdPrioridadDocumentoNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroClienteNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroProveedorNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioAsignadoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioEnUsoNavigation { get; set; } = null!;
    public virtual ICollection<DocDocumento> InverseIdDocumentoNavigation { get; set; } = new List<DocDocumento>();
}
