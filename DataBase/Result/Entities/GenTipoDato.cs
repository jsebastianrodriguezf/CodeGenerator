namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenTipoDato : GenTipoDatoObject
{
    public virtual ICollection<GenDetalleFormulario> GenDetalleFormularios { get; set; } = new List<GenDetalleFormulario>();
}
