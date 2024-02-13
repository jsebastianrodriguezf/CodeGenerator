namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquEstadoPrestamo : EquEstadoPrestamoObject
{
    public virtual ICollection<EquPrestamo> EquPrestamos { get; set; } = new List<EquPrestamo>();
}
