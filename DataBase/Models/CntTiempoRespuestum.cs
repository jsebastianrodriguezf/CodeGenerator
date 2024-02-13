using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntTiempoRespuestum
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TiempoRespuesta { get; set; } = null!;

    public string? TiempoRespuestaCodigo { get; set; }

    public int TiempoLimite { get; set; }

    public int IdContrato { get; set; }

    public int IdPrioridadDocumento { get; set; }

    public int IdEstrategiaPrioridad { get; set; }

    public virtual CntContrato IdContratoNavigation { get; set; } = null!;

    public virtual DocEstrategiaPrioridad IdEstrategiaPrioridadNavigation { get; set; } = null!;

    public virtual DocPrioridadDocumento IdPrioridadDocumentoNavigation { get; set; } = null!;
}
