namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProEntregable : ProEntregableObject
{
    public virtual ICollection<DocDocumentoProyectoEntregable> DocDocumentoProyectoEntregables { get; set; } = new List<DocDocumentoProyectoEntregable>();
}
