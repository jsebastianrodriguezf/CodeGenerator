namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoProyectoEntregable : DocDocumentoProyectoEntregableObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
    public virtual ProEntregable IdEntregableNavigation { get; set; } = null!;
}
