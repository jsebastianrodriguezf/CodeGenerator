namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtReporteTecnico : OrtReporteTecnicoObject
{
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
