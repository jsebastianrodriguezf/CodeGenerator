using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntPeriodoContrato
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PeriodoContrato { get; set; } = null!;

    public string? PeriodoContratoCodigo { get; set; }

    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
}
