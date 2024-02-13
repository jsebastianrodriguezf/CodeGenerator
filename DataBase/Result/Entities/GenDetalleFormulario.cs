namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenDetalleFormulario : GenDetalleFormularioObject
{
    public virtual Columna? IdColumnaNavigation { get; set; }
    public virtual GenFormulario IdFormularioNavigation { get; set; } = null!;
    public virtual GenTipoDato IdTipoDatoNavigation { get; set; } = null!;
}
