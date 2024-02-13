namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenFormulario : GenFormularioObject
{
    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributos { get; set; } = new List<GenConfiguracionAtributo>();
    public virtual ICollection<GenDetalleFormulario> GenDetalleFormularios { get; set; } = new List<GenDetalleFormulario>();
    public virtual ICollection<SegPerfilFormulario> SegPerfilFormularios { get; set; } = new List<SegPerfilFormulario>();
}
