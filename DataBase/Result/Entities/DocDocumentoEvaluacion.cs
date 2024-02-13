namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoEvaluacion : DocDocumentoEvaluacionObject
{
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual DocEvaluacion IdEvaluacionNavigation { get; set; } = null!;
}
