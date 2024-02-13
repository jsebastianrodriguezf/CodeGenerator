namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerContactoEquipo : TerContactoEquipoObject
{
    public virtual TerContacto IdContactoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
