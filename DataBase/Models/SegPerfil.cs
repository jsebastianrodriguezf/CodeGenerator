using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegPerfil
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Perfil { get; set; } = null!;

    public string? PerfilCodigo { get; set; }

    public string? Descripcion { get; set; }

    public bool? MostrarBotones { get; set; }

    public bool? ParaCliente { get; set; }

    public bool? ParaProveedor { get; set; }

    public virtual ICollection<DocEstadoTipoDocumentoPerfil> DocEstadoTipoDocumentoPerfils { get; set; } = new List<DocEstadoTipoDocumentoPerfil>();

    public virtual ICollection<SegPerfilBloqueHome> SegPerfilBloqueHomes { get; set; } = new List<SegPerfilBloqueHome>();

    public virtual ICollection<SegPerfilFormulario> SegPerfilFormularios { get; set; } = new List<SegPerfilFormulario>();

    public virtual ICollection<SegPerfilFuncionalidad> SegPerfilFuncionalidads { get; set; } = new List<SegPerfilFuncionalidad>();

    public virtual ICollection<SegPerfilSubtipoDocumento> SegPerfilSubtipoDocumentos { get; set; } = new List<SegPerfilSubtipoDocumento>();

    public virtual ICollection<SegPerfilTercero> SegPerfilTerceros { get; set; } = new List<SegPerfilTercero>();

    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}
