namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProHito : ProHitoObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
    public virtual ICollection<ProActividadHito> ProActividadHitos { get; set; } = new List<ProActividadHito>();
}
