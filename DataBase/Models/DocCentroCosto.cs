using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocCentroCosto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CentroCosto { get; set; } = null!;

    public string? CentroCostoCodigo { get; set; }

    public virtual ICollection<DocDocumentoOtCentroCosto> DocDocumentoOtCentroCostos { get; set; } = new List<DocDocumentoOtCentroCosto>();

    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
}
