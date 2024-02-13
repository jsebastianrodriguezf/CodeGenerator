using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SynPuntoIntegracionTabla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PuntoIntegracionTabla { get; set; } = null!;

    public string? PuntoIntegracionTablaCodigo { get; set; }

    public int IdPuntoIntegracion { get; set; }

    public string Tabla { get; set; } = null!;

    public virtual SynPuntoIntegracion IdPuntoIntegracionNavigation { get; set; } = null!;
}
