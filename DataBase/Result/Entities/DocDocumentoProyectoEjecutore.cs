namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoProyectoEjecutore : DocDocumentoProyectoEjecutoreObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
}
