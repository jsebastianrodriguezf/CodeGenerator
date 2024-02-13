using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenTipoNotificacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoNotificacion { get; set; } = null!;

    public string? TipoNotificacionCodigo { get; set; }

    public virtual ICollection<GenAccionNotificacion> GenAccionNotificacions { get; set; } = new List<GenAccionNotificacion>();

    public virtual ICollection<GenNotificacion> GenNotificacions { get; set; } = new List<GenNotificacion>();
}
