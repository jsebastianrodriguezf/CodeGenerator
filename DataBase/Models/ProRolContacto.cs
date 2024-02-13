using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProRolContacto
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

    public int IdContacto { get; set; }

    public virtual TerContacto IdContactoNavigation { get; set; } = null!;

    public virtual ProRol IdRolNavigation { get; set; } = null!;
}
