namespace SAMMAI.DataBase.Repository.Entities;

public partial class Columna : ColumnaObject
{
    public virtual ICollection<GenDetalleFormulario> GenDetalleFormularios { get; set; } = new List<GenDetalleFormulario>();
    public virtual Tabla IdTablaNavigation { get; set; } = null!;
}
