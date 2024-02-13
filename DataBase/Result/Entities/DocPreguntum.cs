namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocPreguntum : DocPreguntumObject
{
    public virtual ICollection<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuesta { get; set; } = new List<DocDocumentoOpcionRespuestum>();
    public virtual ICollection<DocOpcionRespuestum> DocOpcionRespuesta { get; set; } = new List<DocOpcionRespuestum>();
    public virtual DocEvaluacion IdEvaluacionNavigation { get; set; } = null!;
}
