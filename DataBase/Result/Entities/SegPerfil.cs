namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfil : SegPerfilObject
{
    public virtual ICollection<DocEstadoTipoDocumentoPerfil> DocEstadoTipoDocumentoPerfils { get; set; } = new List<DocEstadoTipoDocumentoPerfil>();
    public virtual ICollection<SegPerfilBloqueHome> SegPerfilBloqueHomes { get; set; } = new List<SegPerfilBloqueHome>();
    public virtual ICollection<SegPerfilFormulario> SegPerfilFormularios { get; set; } = new List<SegPerfilFormulario>();
    public virtual ICollection<SegPerfilFuncionalidad> SegPerfilFuncionalidads { get; set; } = new List<SegPerfilFuncionalidad>();
    public virtual ICollection<SegPerfilSubtipoDocumento> SegPerfilSubtipoDocumentos { get; set; } = new List<SegPerfilSubtipoDocumento>();
    public virtual ICollection<SegPerfilTercero> SegPerfilTerceros { get; set; } = new List<SegPerfilTercero>();
    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}
