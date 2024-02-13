using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatSoporteActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SoporteActividad { get; set; } = null!;

    public string? SoporteActividadCodigo { get; set; }

    public double Duracion { get; set; }

    public int IdDetalleTempario { get; set; }

    public int IdCargo { get; set; }

    public virtual SegCargo IdCargoNavigation { get; set; } = null!;

    public virtual CatDetalleTempario IdDetalleTemparioNavigation { get; set; } = null!;
}
