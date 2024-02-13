using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegCargoActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CargoActividad { get; set; } = null!;

    public int IdCargo { get; set; }

    public int IdCatalogoActividad { get; set; }

    public virtual SegCargo IdCargoNavigation { get; set; } = null!;

    public virtual CatCatalogoActividad IdCatalogoActividadNavigation { get; set; } = null!;
}
