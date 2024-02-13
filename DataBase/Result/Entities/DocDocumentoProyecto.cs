namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoProyecto : DocDocumentoProyectoObject
{
    public virtual ICollection<DocDocumentoProyectoEjecutore> DocDocumentoProyectoEjecutores { get; set; } = new List<DocDocumentoProyectoEjecutore>();
    public virtual ICollection<DocDocumentoProyectoEntregable> DocDocumentoProyectoEntregables { get; set; } = new List<DocDocumentoProyectoEntregable>();
    public virtual ICollection<DocDocumentoProyectoEtapa> DocDocumentoProyectoEtapas { get; set; } = new List<DocDocumentoProyectoEtapa>();
    public virtual ICollection<DocDocumentoProyectoSucursal> DocDocumentoProyectoSucursals { get; set; } = new List<DocDocumentoProyectoSucursal>();
    public virtual ICollection<ProHito> ProHitos { get; set; } = new List<ProHito>();
    public virtual ICollection<ProHorarioProyecto> ProHorarioProyectos { get; set; } = new List<ProHorarioProyecto>();
}
