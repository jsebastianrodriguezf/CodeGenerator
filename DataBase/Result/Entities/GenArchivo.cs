namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenArchivo : GenArchivoObject
{
    public virtual ICollection<ProEjecutoresArchivo> ProEjecutoresArchivos { get; set; } = new List<ProEjecutoresArchivo>();
}
