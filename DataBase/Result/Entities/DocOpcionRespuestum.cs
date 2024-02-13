namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocOpcionRespuestum : DocOpcionRespuestumObject
{
    public virtual ICollection<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuesta { get; set; } = new List<DocDocumentoOpcionRespuestum>();
    public virtual DocPreguntum IdPreguntaNavigation { get; set; } = null!;
}
