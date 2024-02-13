using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerContacto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Contacto { get; set; } = null!;

    public string? ContactoCodigo { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string? TelefonoMovil { get; set; }

    public int IdTercero { get; set; }

    public int IdUsuario { get; set; }

    public string? Cargo { get; set; }

    public string? CodigoAcceso { get; set; }

    public int? IdCargoContacto { get; set; }

    public bool AccesoActivo { get; set; }

    public int? TerCargoContactoIdUsuarioModifico { get; set; }

    public int? TerCargoContactoIdUsuarioCreo { get; set; }

    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();

    public virtual ICollection<DocDocumentoContacto> DocDocumentoContactos { get; set; } = new List<DocDocumentoContacto>();

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<ProRolContacto> ProRolContactos { get; set; } = new List<ProRolContacto>();

    public virtual ICollection<TerContactoEquipo> TerContactoEquipos { get; set; } = new List<TerContactoEquipo>();

    public virtual ICollection<TerContactoSucursal> TerContactoSucursals { get; set; } = new List<TerContactoSucursal>();
}
