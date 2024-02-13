namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProEjecutoresArchivo : ProEjecutoresArchivoObject
{
    public virtual GenArchivo IdArchivoNavigation { get; set; } = null!;
    public virtual ProEjecutore IdEjecutoresNavigation { get; set; } = null!;
}
