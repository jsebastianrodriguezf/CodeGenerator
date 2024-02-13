namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProEtapa : ProEtapaObject
{
    public virtual ICollection<DocDocumentoProyectoEtapa> DocDocumentoProyectoEtapas { get; set; } = new List<DocDocumentoProyectoEtapa>();
    public virtual ICollection<ProActividadEtapa> ProActividadEtapas { get; set; } = new List<ProActividadEtapa>();
}
