using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProActividadEtapa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ActividadEtapa { get; set; } = null!;

    public int IdEtapa { get; set; }

    public int IdActividad { get; set; }

    public virtual ProActividad IdActividadNavigation { get; set; } = null!;

    public virtual ProEtapa IdEtapaNavigation { get; set; } = null!;
}
