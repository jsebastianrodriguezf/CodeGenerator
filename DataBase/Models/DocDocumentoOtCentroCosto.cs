using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoOtCentroCosto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOtCentroCosto { get; set; } = null!;

    public double? Porcentaje { get; set; }

    public int IdCentroCosto { get; set; }

    public int IdDocumentoOt { get; set; }

    public virtual DocCentroCosto IdCentroCostoNavigation { get; set; } = null!;

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
