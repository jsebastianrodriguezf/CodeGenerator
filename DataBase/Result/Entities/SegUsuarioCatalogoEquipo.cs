namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegUsuarioCatalogoEquipo : SegUsuarioCatalogoEquipoObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
