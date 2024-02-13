namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoProyectoEtapa : DocDocumentoProyectoEtapaObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
    public virtual ProEtapa IdEtapaNavigation { get; set; } = null!;
}
