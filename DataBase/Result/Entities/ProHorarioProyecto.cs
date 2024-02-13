namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProHorarioProyecto : ProHorarioProyectoObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
}
