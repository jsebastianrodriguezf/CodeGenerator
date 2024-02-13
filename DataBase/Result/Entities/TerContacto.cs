namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerContacto : TerContactoObject
{
    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();
    public virtual ICollection<DocDocumentoContacto> DocDocumentoContactos { get; set; } = new List<DocDocumentoContacto>();
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<ProRolContacto> ProRolContactos { get; set; } = new List<ProRolContacto>();
    public virtual ICollection<TerContactoEquipo> TerContactoEquipos { get; set; } = new List<TerContactoEquipo>();
    public virtual ICollection<TerContactoSucursal> TerContactoSucursals { get; set; } = new List<TerContactoSucursal>();
}
