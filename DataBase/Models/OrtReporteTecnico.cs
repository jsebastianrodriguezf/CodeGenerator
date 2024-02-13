using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class OrtReporteTecnico
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ReporteTecnico { get; set; } = null!;

    public string? ReporteTecnicoCodigo { get; set; }

    public string? Numero { get; set; }

    public string? Trabajos { get; set; }

    public string? Recomendaciones { get; set; }

    public string? Compromisos { get; set; }

    public int IdGasto { get; set; }

    public int? IdCanalAtencion { get; set; }

    public string Diagnostico { get; set; } = null!;

    public int? IdDocumentoGasto { get; set; }

    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();

    public virtual ICollection<DocPendienteDocumento> DocPendienteDocumentos { get; set; } = new List<DocPendienteDocumento>();

    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual OrtCanalAtencion? IdCanalAtencionNavigation { get; set; }

    public virtual DocDocumentoGasto? IdDocumentoGastoNavigation { get; set; }

    public virtual GasGasto IdGastoNavigation { get; set; } = null!;

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();

    public virtual ICollection<OrtReporteTecnicoFalla> OrtReporteTecnicoFallas { get; set; } = new List<OrtReporteTecnicoFalla>();
}
