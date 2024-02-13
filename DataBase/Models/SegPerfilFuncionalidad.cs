using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegPerfilFuncionalidad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PerfilFuncionalidad { get; set; } = null!;

    public int IdPerfil { get; set; }

    public int IdFuncionalidad { get; set; }

    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;

    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
