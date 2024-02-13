using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoGasto { get; set; } = null!;

    public DateTime FechaFf { get; set; }

    public int Dias { get; set; }

    public string Concepto { get; set; } = null!;

    public bool Consignado { get; set; }

    public int IdUsuarioSolicitante { get; set; }

    public virtual DocDocumento IdNavigation { get; set; } = null!;

    public virtual ICollection<OrtReporteTecnico> OrtReporteTecnicos { get; set; } = new List<OrtReporteTecnico>();
}
