namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProGrupoSesion : ProGrupoSesionObject
{
    public virtual ICollection<ProSesionActividad> ProSesionActividads { get; set; } = new List<ProSesionActividad>();
}
