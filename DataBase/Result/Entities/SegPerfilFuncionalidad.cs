namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfilFuncionalidad : SegPerfilFuncionalidadObject
{
    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
