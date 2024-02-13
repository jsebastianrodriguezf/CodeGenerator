using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoActividad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoActividad { get; set; } = null!;

    public bool? EsProductiva { get; set; }

    public double? DuracionEstimada { get; set; }

    public string? Procedimiento { get; set; }

    public int DiasGarantia { get; set; }

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();

    public virtual ICollection<SegCargoActividad> SegCargoActividads { get; set; } = new List<SegCargoActividad>();
}
