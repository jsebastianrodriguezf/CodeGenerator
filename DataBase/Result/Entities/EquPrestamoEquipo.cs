namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquPrestamoEquipo : EquPrestamoEquipoObject
{
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual EquPrestamo IdPrestamoNavigation { get; set; } = null!;
}
