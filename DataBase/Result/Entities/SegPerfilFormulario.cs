namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegPerfilFormulario : SegPerfilFormularioObject
{
    public virtual GenFormulario IdFormularioNavigation { get; set; } = null!;
    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;
}
