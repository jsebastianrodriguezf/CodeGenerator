namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquPrestamo : EquPrestamoObject
{
    public virtual ICollection<EquPrestamoEquipo> EquPrestamoEquipos { get; set; } = new List<EquPrestamoEquipo>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
    public virtual EquEstadoPrestamo IdEstadoPrestamoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioEntregoNavigation { get; set; } = null!;
}
