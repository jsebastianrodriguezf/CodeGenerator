namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocEvaluacion : DocEvaluacionObject
{
    public virtual ICollection<DocDocumentoEvaluacion> DocDocumentoEvaluacions { get; set; } = new List<DocDocumentoEvaluacion>();
    public virtual ICollection<DocPreguntum> DocPregunta { get; set; } = new List<DocPreguntum>();
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
}
