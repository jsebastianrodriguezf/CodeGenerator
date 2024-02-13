namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquAnalisisFalla : EquAnalisisFallaObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaCausaNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaEfectoNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaSolucionNavigation { get; set; } = null!;
}
