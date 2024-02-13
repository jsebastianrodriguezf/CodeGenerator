using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProRolContacto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RolContacto { get; set; } = null!;

    public int IdRol { get; set; }

    public string ProRolRol { get; set; } = null!;

    public string? ProRolRolCodigo { get; set; }

    public int IdContacto { get; set; }

    public string TerContactoContacto { get; set; } = null!;

    public string? TerContactoContactoCodigo { get; set; }

    public string TerContactoTelefono { get; set; } = null!;

    public string? TerContactoFax { get; set; }

    public string? TerContactoEmail { get; set; }

    public string? TerContactoDireccion { get; set; }

    public string? TerContactoTelefonoMovil { get; set; }

    public int TerContactoIdTercero { get; set; }

    public int TerContactoIdUsuario { get; set; }

    public string? TerContactoCargo { get; set; }

    public string? TerContactoCodigoAcceso { get; set; }

    public int? TerContactoIdCargoContacto { get; set; }

    public bool TerContactoAccesoActivo { get; set; }

    public string Multiempresa { get; set; } = null!;
}
