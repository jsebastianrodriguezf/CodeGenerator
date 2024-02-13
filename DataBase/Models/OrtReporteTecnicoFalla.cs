using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class OrtReporteTecnicoFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ReporteTecnicoFalla { get; set; } = null!;

    public int IdReporteTecnico { get; set; }

    public int IdFalla { get; set; }

    public int IdFallaCausa { get; set; }

    public int IdFallaEfecto { get; set; }

    public virtual EquFalla IdFallaCausaNavigation { get; set; } = null!;

    public virtual EquFalla IdFallaEfectoNavigation { get; set; } = null!;

    public virtual EquFalla IdFallaNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
}
