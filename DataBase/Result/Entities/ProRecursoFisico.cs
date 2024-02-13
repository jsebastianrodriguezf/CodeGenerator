namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProRecursoFisico : ProRecursoFisicoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual ICollection<ProActividadRecursoFisico> ProActividadRecursoFisicos { get; set; } = new List<ProActividadRecursoFisico>();
}
