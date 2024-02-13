using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenBodegaUsuario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string BodegaUsuario { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int IdBodega { get; set; }

    public bool Sugerir { get; set; }

    public virtual GenBodega IdBodegaNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
