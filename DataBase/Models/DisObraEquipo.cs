using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisObraEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ObraEquipo { get; set; } = null!;

    public int IdObra { get; set; }

    public int IdEquipo { get; set; }

    public double PromedioEsperado { get; set; }

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual DisObra IdObraNavigation { get; set; } = null!;
}
