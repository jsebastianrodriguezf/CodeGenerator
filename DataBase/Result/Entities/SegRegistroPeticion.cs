namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegRegistroPeticion : SegRegistroPeticionObject
{
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
