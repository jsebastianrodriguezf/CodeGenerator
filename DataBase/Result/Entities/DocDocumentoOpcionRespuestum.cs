namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoOpcionRespuestum : DocDocumentoOpcionRespuestumObject
{
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocOpcionRespuestum IdOpcionRespuestaNavigation { get; set; } = null!;
    public virtual DocPreguntum IdPreguntaNavigation { get; set; } = null!;
}
